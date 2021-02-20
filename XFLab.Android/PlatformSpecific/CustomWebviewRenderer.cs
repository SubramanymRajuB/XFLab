﻿using Android.Content;
using Android.Views;
using Android.Webkit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFLab.Droid.Renderers;
using XFWebView = Xamarin.Forms.WebView;

[assembly: ExportRenderer(typeof(XFWebView), typeof(CustomWebviewRenderer))]
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
            if (Control != null)
            {
                bool scrollEnabled = false;
                Control.VerticalScrollBarEnabled = scrollEnabled;
                Control.HorizontalScrollBarEnabled = scrollEnabled;
                Control.SetWebViewClient(new CustomWebViewClient(Element));
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
    }

    public class CustomWebViewClient : WebViewClient
    {
        XFWebView _webView;

        public CustomWebViewClient(XFWebView webView)
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
            base.OnPageFinished(view, url);
        }
    }
}