using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class EssentialsPage : ContentPage
    {
        public EssentialsPage()
        {
            InitializeComponent();
        }

        void Connectvity_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ConnectivityPage());
        }

        void AppInfo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AppInfoPage());
        }

        void Preferences_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PreferencesPage());
        }

        void Permissions_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PermissionsPage());
        }

        void Dialer_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PhoneDialerPage());
        }

        void Email_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EmailPage());
        }

        void Launcher_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LauncherPage());
        }

        void FilePicker_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilePickerPage());
        }

        void VersionTracking_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VersionTrackingDemo());
        }

        void SecureStorage_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SecureStoragePage());
        }
    }
}
