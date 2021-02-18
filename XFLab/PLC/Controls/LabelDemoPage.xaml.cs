using System;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public partial class LabelDemoPage : ContentPage
    {
        public LabelDemoPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, System.EventArgs e)
        {
            MessagingCenter.Send<object, int>(this, "LABEL_DEMO", 2);
            await Navigation.PopAsync();
        }
    }
}