
using Xamarin.Forms;

namespace XFLab
{
    public partial class LocalizationDemo : ContentPage
    {
        public LocalizationDemo()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangeLanguagePage());
        }
    }
}
