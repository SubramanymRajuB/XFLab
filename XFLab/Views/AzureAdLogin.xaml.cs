using System;
using Xamarin.Forms;
using XFLab.Models;
using XFLab.MSAL;

namespace XFLab.Views
{
    public partial class AzureAdLogin : ContentPage
    {
        AzureADAuthProvider _auth;
        public AzureAdLogin()
        {
            InitializeComponent();
        }

        async void Login_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                gridLoader.IsVisible = true;
                _auth = new AzureADAuthProvider("b1e54ab8-d830-4d4e-9490-7a2dc68f6a5f", "auth", "d4f702d0-da12-42f5-93f2-7727f294f413", new string[] { "https://graph.microsoft.com/User.Read" });
                if (await _auth.SignInAsync(App.ParentWindow, Device.RuntimePlatform))
                {
                    userName.Text = User.USER_FULL_NAME;
                }
            }
            catch(Exception ex)
            {

            }
            gridLoader.IsVisible = false;
        }

        async void Singout_Clicked(System.Object sender, System.EventArgs e)
        {
            gridLoader.IsVisible = true;
            await _auth.SignOutAsync();
            userName.Text = "";
            gridLoader.IsVisible = false;
        }
    }
}
