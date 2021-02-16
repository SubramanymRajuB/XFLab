using System;
using Xamarin.Forms;
//using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using XFLab.Views;

namespace FormsGallery.XamlExamples
{
    public partial class TabbedPageDemoPage : TabbedPage
    {
        public TabbedPageDemoPage()
        {
            InitializeComponent();

            CurrentPage = this.Children[2]; //Default selection for third tab
            //On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new XamlCsharp());
        }
    }
}