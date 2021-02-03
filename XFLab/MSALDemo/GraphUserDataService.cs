using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using XFLab.Models;

namespace XFLab.MSAL
{
    public class GraphUserDataService
    {
        /// <summary>
        /// Call Graph API with an access token, the token must be for the Graph resource.
        /// </summary>
        public static async Task<GraphUserData> LoadFromGraphApi(string tokenType, string token)
        {
            var client = new HttpClient();
            var message = new HttpRequestMessage(
                HttpMethod.Get,
                "https://graph.microsoft.com/v1.0/me?$select=displayName,givenName,onPremisesSamAccountName,employeeId,mail,country"
            //"https://graph.microsoft.com/v1.0/me?$select=id,userPrincipalName,displayName,givenName,surname,jobTitle,mail,mobilePhone,officeLocation,onPremisesSamAccountName,employeeId"
            );
            // Should be "bearer" token.
            message.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, token);
            var response = await client.SendAsync(message);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(
                    $"Was unable to load user data from Graph API. Response = {response.StatusCode} '{response.Content}'."
                );
            }

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(responseString));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GraphUserData));
            var userData = ser.ReadObject(ms) as GraphUserData;

            return userData;
        }
    }
}

