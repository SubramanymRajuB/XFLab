using System;

using Xamarin.Forms;
using XFLab.PlatformSpecific;

namespace XFLab.Views
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
