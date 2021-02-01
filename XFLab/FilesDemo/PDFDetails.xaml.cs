using System.IO;
using System.Net;
using System.Reflection;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFLab.PlatformSpecific;

namespace XFLab.FilesDemo
{
    public partial class PDFDetails : ContentPage
    {
        public PDFDetails()
        {
            InitializeComponent();
        }

        async void PDFDemo_Clicked(System.Object sender, System.EventArgs e)
        {

            var assembly = typeof(PDFDetails).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{"FilesDemo.Xamarin.pdf"}");

            // Get platform specific device file path
            var dependency = DependencyService.Get<ILocalFileProvider>();
            string localPath = await dependency.SaveFileToDiskAsync(stream, $"Xamarin.pdf");

            if (DeviceInfo.Platform.ToString() == Device.iOS)
            {
                webViewPDF.Source = localPath;
                gridLoader.IsVisible = false;
            }
            else
            {
                gridLoader.IsVisible = true;
                webViewPDF.Source = $"file:///android_asset/pdfjs/web/viewer.html?file={WebUtility.UrlEncode(localPath)}";
                webViewPDF.Navigated += webViewPDF_Navigated;
            }
        }

        void webViewPDF_Navigated(object sender, WebNavigatedEventArgs e)
        {
            gridLoader.IsVisible = false;
        }
    }
}
