using System;
using FormsGallery;
using Styles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFLab.Intro;
using XFLab.PageNavigations;
using XFLab.PlatformSpecific;

namespace XFLab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Xaml vs Csharp DEMO
            //MainPage = new NavigationPage(new XamlCsharp());

            //PLC DEMO (Pages, Layouts, Controls)
            //MainPage = new NavigationPage(new PLCPage());

            //Pass data demo
            //MainPage = new NavigationPage(new PassDataPageOne());

            //Customrenderer demo
            //MainPage = new NavigationPage(new EntryRendererPage());

            //DependencyService demo
            //MainPage = new NavigationPage(new DPPage());

            //Styles demo
            MainPage = new NavigationPage(new StylesListPage());
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
