using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.PlatformSpecific
{
    public partial class DPPage : ContentPage
    {
        public DPPage()
        {
            InitializeComponent();
        }

        void OnGetDeviceOrientationButtonClicked(object sender, EventArgs e)
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            orientationLabel.Text = orientation.ToString();
        }

    }
}
