using Xamarin.Essentials;

namespace XFLab.ViewModels
{
    public class ConnectivityViewModel : BaseViewModel
    {
        public ConnectivityViewModel()
        {
        }

        public string NetworkStatus =>
            Connectivity.NetworkAccess.ToString();

        public string ConnectionProfiles
        {
            get
            {
                var profiles = string.Empty;
                foreach (var p in Connectivity.ConnectionProfiles)
                    profiles += "\n" + p.ToString();
                return profiles;
            }
        }

        public override void OnAppearing()
        {
            base.OnAppearing();

            Connectivity.ConnectivityChanged += OnConnectivityChanged;
        }

        public override void OnDisappearing()
        {
            Connectivity.ConnectivityChanged -= OnConnectivityChanged;

            base.OnDisappearing();
        }

        async void OnConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ConnectionProfiles));
            OnPropertyChanged(nameof(NetworkAccess));

            if(NetworkStatus != NetworkAccess.Internet.ToString())
            {
                await DisplayAlertAsync("No network is available.");
            }
            else
            {
                await DisplayAlertAsync(ConnectionProfiles +" Network is available.");
            }

        }
    }
}
