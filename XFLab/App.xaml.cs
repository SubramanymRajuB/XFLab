using DataBindingDemos;
using Xamarin.Forms;
using XFLab.Views;

[assembly: ExportFont("Samantha.ttf")]
[assembly: ExportFont("FA5Regular.otf", Alias = "FontAwesome")]
namespace XFLab
{
    public partial class App : Application
    {
        public static object ParentWindow { get; set; }
        public SampleSettingsViewModel Settings { get; private set; }
        public App()
        {
            InitializeComponent();
            Settings = new SampleSettingsViewModel(Current.Properties);

            //Shell demo
            //MainPage = new AppShell();

            //Test
            //MainPage = new NavigationPage(new TiggersDemo());

            //WelcomePage
            MainPage = new NavigationPage(new WelcomePage())
            {
                BarBackgroundColor = Color.FromHex("#2880b9"),
                BarTextColor = Color.White
            };
        }

        //Called when the application starts.
        protected override void OnStart()
        {
        }

        //Called each time the application goes to the background.
        protected override void OnSleep()
        {
        }

        //Called when the application is resumed, after being sent to the background.
        protected override void OnResume()
        {
        }
    }
}
