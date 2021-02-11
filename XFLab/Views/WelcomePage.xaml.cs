﻿using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        void XamlCsharpDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamlCsharp());
        }

        void PLCDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PLCPage());
        }

        void PassingData_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PassDataPageOne());
        }

        void CustomRendererDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EntryRendererPage());
        }

        void DependencyServiceDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DPPage());
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
