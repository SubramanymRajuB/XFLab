using System;
using Xamarin.Forms;
using XFLab.Models;

namespace XFLab.Views
{
    public partial class WelcomePage : ContentPage
    {
        DateTime StartTimeLog;
        public WelcomePage()
        {
            InitializeComponent();
        }

        void XamlCsharpDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new XamlCsharp());
            LogAppAnalytics.Capture(StartTimeLog, "XamlCsharpDemo");

        }

        void MarkupExtensions_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new MarkupExtensionDemo());
            LogAppAnalytics.Capture(StartTimeLog, "MarkupExtensionDemo");
        }

        void DesignTime_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new DesignTimeDataDemo());
            LogAppAnalytics.Capture(StartTimeLog, "DesignTimeDataDemo");
        }

        void PLCDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new PLCPage());
            LogAppAnalytics.Capture(StartTimeLog, "PLCPage");
        }

        void PassingData_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new PassDataPageOne());
            LogAppAnalytics.Capture(StartTimeLog, "PassDataPageOne");
        }

        void CustomRendererDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new EntryRendererPage());
            LogAppAnalytics.Capture(StartTimeLog, "EntryRendererPage");
        }

        void DependencyServiceDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            StartTimeLog = DateTime.Now;
            Navigation.PushAsync(new DPPage());
            LogAppAnalytics.Capture(StartTimeLog, "DPPage");
        }

        void StylesDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StylesListPage());
        }

        void DataBindingDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DatabindingDemo());
        }

        void ListViewDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListViewDemoPage());
        }

        void CollectionViewDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CollectionViewDemo());
        }

        void CustomControlDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        void TriggersDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TiggersDemo());
        }

        void BehaviorsDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BehaviorsDemo());
        }

        void EssentialsDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EssentialsPage());
        }

        void ThirdPartyDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ThirdPartyDemo());
        }

        void NativeBinding_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NativeLibraryPage());
        }

        void FilesDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilesDemo());
        }

        void MSAL_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AzureAdLogin());
        }

        void Accessbility_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AccessibilityDemo());
        }

        void EmbeddedFonts_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EmbeddedFontsPage());
        }

        void VSM_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VSMTargetDemo ());
        }

        void Brushes_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GradientsBrushesDemo());
        }

        void RadioButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RadioButtonChangesDemo());
        }

        void ShellButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AppShell());
        }
    }
}
