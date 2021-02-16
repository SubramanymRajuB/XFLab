using System;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public partial class ScrollViewDemoPage : ContentPage
    {
        public ScrollViewDemoPage()
        {
            InitializeComponent();
        }

        void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
        {
            Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
        }

        async void btn_Clicked(System.Object sender, System.EventArgs e)
        {
            //await scrollView.ScrollToAsync(0, 150, true);// Scroll a position into view
            await scrollView.ScrollToAsync(label, ScrollToPosition.Start, true);
        }
    }
}