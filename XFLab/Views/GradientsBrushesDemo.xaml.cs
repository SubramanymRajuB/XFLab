using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class GradientsBrushesDemo : ContentPage
    {
        public GradientsBrushesDemo()
        {
            InitializeComponent();
        }

        void Solid_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SolidColorBrushDemoPage());
        }

        void Linear_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LinearGradientBrushDemoPage());
        }

        void Radial_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RadialGradientBrushDemoPage());
        }

        void UpdateBrush_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new UpdateBrushDemoPage());
        }
    }
}
