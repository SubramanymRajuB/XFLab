using System.ComponentModel;
using Android.Content;
using Android.Views;
using Android.Webkit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFLab.Controls;
using XFLab.Droid.Renderers;
using XFWebView = Xamarin.Forms.WebView;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebviewRenderer))]
namespace XFLab.Droid.Renderers
{
    public class CustomWebviewRenderer : WebViewRenderer
    {
        public CustomWebviewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<XFWebView> e)
        {
            base.OnElementChanged(e);
            if (Control != null && e.NewElement != null)
            {
                var element = Element as CustomWebView;
                Control.SetWebViewClient(new CustomWebViewClient(element));
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Element != null && Control != null)
            {
                var element = Element as CustomWebView;
                if (element.ExpectedHieght > 0 && element.HeightRequest >= element.ExpectedHieght)
                {
                    element.HeightRequest = element.ExpectedHieght;

                    DisableScroll(true);
                }
                else
                {
                    DisableScroll(false);
                }
            }
        }

        void DisableScroll(bool scrollEnabled)
        {
            Control.VerticalScrollBarEnabled = scrollEnabled;
            Control.HorizontalScrollBarEnabled = scrollEnabled;
            Control.Touch += (senderr, touch) =>
            {
                if (!scrollEnabled)
                {
                    touch.Handled = touch.Event.Action == MotionEventActions.Move;
                }
                else
                {
                    touch.Handled = false;
                }
            };
        }
    }

    public class CustomWebViewClient : WebViewClient
    {
        CustomWebView _webView;

        public CustomWebViewClient(CustomWebView webView)
        {
            _webView = webView;
        }

        public override async void OnPageFinished(Android.Webkit.WebView view, string url)
        {
            if (_webView != null)
            {
                int i = 10;
                while (view.ContentHeight == 0 && i-- > 0) // wait here till content is rendered
                    await System.Threading.Tasks.Task.Delay(100);
                _webView.HeightRequest = view.ContentHeight;
            }
            _webView?.InvokeCompleted();
            base.OnPageFinished(view, url);
        }
    }
}
