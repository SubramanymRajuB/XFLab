using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new SignUpPage());
		}
    }
}
