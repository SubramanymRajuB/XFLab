using System;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public partial class TabbedPageDemoPage : TabbedPage
    {
        public TabbedPageDemoPage()
        {
            InitializeComponent();

            CurrentPage = this.Children[2]; //Default selection for third tab
        }
    }
}