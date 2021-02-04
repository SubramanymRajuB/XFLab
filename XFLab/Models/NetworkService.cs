using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamCommonFeatures.Services
{
    public class NetworkCheck
    {
        public NetworkCheck()
        {
            // Register for connectivity changes, be sure to unsubscribe when finished
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }
        // Pass isAlert=true if netwrok alert is required
        public static async Task<Boolean> IsInternet(bool isAlert = true)
        {

            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                return true;
            }
            else
            {
                if (isAlert)
                {
                    // Disaplying netwrok alert message
                    await Application.Current.MainPage.DisplayAlert("", "Please try once network is available.", "Ok");
                }
                return false;
            }

        }

        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var access = e.NetworkAccess;
            var profiles = e.ConnectionProfiles;
        }
    }
}
