using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFLab.iOS.Renderers;

//[assembly: ExportRenderer(typeof(WebView), typeof(PdfWebViewRenderer))]
namespace XFLab.iOS.Renderers
{
    public class PdfWebViewRenderer : WkWebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            var view = (UIWebView)NativeView;
            view.ScrollView.ScrollEnabled = true;
            view.ScalesPageToFit = true;
        }
    }
}


