using System.ComponentModel;
using Foundation;
using UIKit;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFLab.Controls;
using XFLab.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebviewRenderer))]
namespace XFLab.iOS.Renderers
{
    public class CustomWebviewRenderer : ViewRenderer<CustomWebView, WKWebView>, IWKNavigationDelegate
    {
        WKWebView _wkWebView;
        protected override void OnElementChanged(ElementChangedEventArgs<CustomWebView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var config = new WKWebViewConfiguration();
                _wkWebView = new WKWebView(Frame, config);
                _wkWebView.NavigationDelegate = this;
                _wkWebView.ScrollView.AlwaysBounceVertical = false;
                _wkWebView.ScrollView.Bounces = false;
                _wkWebView.ScrollView.ShowsHorizontalScrollIndicator = false;
                _wkWebView.ScrollView.ShowsVerticalScrollIndicator = false;
                _wkWebView.ScrollView.ScrollEnabled = false;
                _wkWebView.ContentMode = UIKit.UIViewContentMode.ScaleToFill;
                SetNativeControl(_wkWebView);
            }

            if (e.NewElement != null && Element?.Source != null)
            {
                NSUrl baseurl = new NSUrl(NSBundle.MainBundle.BundlePath, true);
                //Control.LoadRequest(new NSUrlRequest(new NSUrl((Element.Source as UrlWebViewSource).Url)));
                Control.LoadHtmlString((Element.Source as HtmlWebViewSource).Html, baseurl);
                _wkWebView.NavigationDelegate = this;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Element != null && Control != null)
            {
                if (Element.ExpectedHieght > 0 && Element.HeightRequest >= Element.ExpectedHieght)
                {
                    Element.HeightRequest = Element.ExpectedHieght;
                    Control.ScrollView.ScrollEnabled = true;
                }
                else
                {
                    Control.ScrollView.ScrollEnabled = false;
                }
            }
        }

        [Export("webView:didFinishNavigation:")]
        public async void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
        {
            if (Element != null)
            {
                await System.Threading.Tasks.Task.Delay(100); // wait here till content is rendered
                Element.HeightRequest = (double)webView.ScrollView.ContentSize.Height;
                Element?.InvokeCompleted();
            }
        }
    }
}
