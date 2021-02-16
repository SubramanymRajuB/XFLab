using System.Collections.Generic;
using Xamarin.Forms;

namespace XFLab
{
    public partial class ReferenceDemoPage : ContentPage
    {
        public ReferenceDemoPage()
        {
            InitializeComponent();
            List<string> items = new List<string>();
            items.Add("Blue");
            items.Add("Red");
            picker.ItemsSource = items;
        }
    }
}