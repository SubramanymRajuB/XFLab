using System;
using Xamarin.Forms;
using XFLab.Views;

namespace FormsGallery.XamlExamples
{
    public partial class TabbedPageDemoPage : TabbedPage
    {
        public TabbedPageDemoPage()
        {
            InitializeComponent();

            CurrentPage = this.Children[2]; //Default selection for third tab
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new XamlCsharp());
        }
    }
}