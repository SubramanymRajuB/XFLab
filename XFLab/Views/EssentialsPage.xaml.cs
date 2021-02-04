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
    }
}
