
using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class ThirdPartyDemo : ContentPage
    {
        public ThirdPartyDemo()
        {
            InitializeComponent();
        }

        void Localization_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LocalizationDemo());
        }

        void Lottie_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LottieAnimationPage());
        }
    }
}
