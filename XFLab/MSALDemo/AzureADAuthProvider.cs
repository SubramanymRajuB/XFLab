using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using XFLab.Models;
using AuthenticationResult = Microsoft.Identity.Client.AuthenticationResult;

namespace XFLab.MSAL
{
    public class AzureADAuthProvider
    {
        /// <summary>
        /// Client ID from the app registration in Azure.
        /// </summary>
        readonly string CLIENT_ID;

        /// <summary>
        /// REDIRECT_URI_HOST will be helpful for supplying different host urls for same azure AD.
        /// It will avoid Suggest app alert in Android.
        /// </summary>
        readonly string REDIRECT_URI_HOST;

        /// <summary>
        /// ID of the tenant.
        /// </summary>
        readonly string TENANT_ID;

        /// <summary>
		/// Requested API permissions/scopes from the app.
		/// </summary>
		readonly string[] Scopes;

        /// <summary>
        /// Additional scopes to get consent for, can be from different resources.
        /// </summary>
        readonly string[] ExtraScopes;

        readonly IPublicClientApplication publicClientApplication;
        List<IAccount> accounts;
        AuthenticationResult authResult;

        public AzureADAuthProvider(string clientID, string host, string tenantID, string[] scopes)
        {
            CLIENT_ID = clientID;
            TENANT_ID = tenantID;
            Scopes = scopes;
            REDIRECT_URI_HOST = host;

            var pca = PublicClientApplicationBuilder.Create(CLIENT_ID)
                       //.WithRedirectUri($"msal{CLIENT_ID}://auth")
                       .WithRedirectUri($"msal{CLIENT_ID}://" + REDIRECT_URI_HOST)
                       .WithTenantId(TENANT_ID);

                // If it's a debug build, log debugging information in console
            #if DEBUG
                 pca = pca.WithDebugLoggingCallback(LogLevel.Info, true, true);
            #endif

            publicClientApplication = pca.Build();
        }


        public async Task<bool> SignInAsync(object parentWindow, string platform)
        {
            await RefreshAccounts();
            try
            {
                IAccount firstAccount = accounts.FirstOrDefault();
                authResult = await publicClientApplication
                                    .AcquireTokenSilent(Scopes, firstAccount)
                                    .ExecuteAsync();

            }
            catch (MsalUiRequiredException)
            {
                // Open a browser window, when token doesn't exist for the user in that device

                // System browser for android, Embedded webview for iOS
                bool isEmbedded = platform?.ToLower() == "android" ? false : true;

                authResult = await publicClientApplication
                        .AcquireTokenInteractive(Scopes)
                        .WithExtraScopesToConsent(ExtraScopes)
                        .WithParentActivityOrWindow(parentWindow)
                        .WithUseEmbeddedWebView(isEmbedded)
                        .ExecuteAsync();

                await RefreshAccounts();

            }

            await RequestTokenAsync("https://graph.microsoft.com/.default"); //Get the token for Graph resource.

            var graphUserData = await GraphUserDataService.LoadFromGraphApi("bearer", User.ACCESS_TOKEN);
            User.EMP_ID = graphUserData?.EmployeeID;
            User.EMAIL = graphUserData?.Email;
            User.COUNTRY = graphUserData?.Country;
            User.USER_NAME = graphUserData?.OnPremisesSamAccountName?.ToLower();
            User.USER_FULL_NAME = graphUserData?.DisplayName;
            User.DISPLAY_NAME = "Welcome, " + graphUserData?.GivenName;

            User.ACCESS_TOKEN = authResult?.AccessToken; // Reset token to your default login resource.

            return true;
        }

        /// <summary>
        /// Sign out of all active accounts associated with this app.
        /// </summary>
        public async Task SignOutAsync()
        {
            do
            {
                var accountsLoaded = await publicClientApplication.GetAccountsAsync();
                accounts = accountsLoaded.ToList();
                await publicClientApplication.RemoveAsync(accounts.FirstOrDefault());
            } while (accounts.Any());

            authResult = null;
            accounts = null;
        }

        public async Task RequestTokenAsync(string scope)
        {
            accounts = (await publicClientApplication.GetAccountsAsync()).ToList();
            var newAuthResult = await publicClientApplication.AcquireTokenSilent(
                    new string[] { scope },
                    accounts.First()
                ).ExecuteAsync();
            User.ACCESS_TOKEN = newAuthResult?.AccessToken;
        }

        private async Task RefreshAccounts()
        {
            var accountsLoaded = await publicClientApplication.GetAccountsAsync();
            accounts = accountsLoaded.ToList();
        }
    }
}
