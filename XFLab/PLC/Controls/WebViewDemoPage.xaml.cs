using System;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public interface IBaseUrl { string Get(); }
    public partial class WebViewDemoPage : ContentPage
    {
        public WebViewDemoPage()
        {
            InitializeComponent();

            //Assigning html string or local html content
            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html>
                                <head>
                                <link rel=""stylesheet"" href=""default.css"">
                                </head>
                                <body>
                                <h1>Xamarin.Forms</h1>
                                <p>The CSS and image are loaded from local files!</p>
                                <img src='XamarinLogo.png'/>
                                <p><a href=""local.html"">next page</a></p>
                                </body>
                                </html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            webView.Source = htmlSource;
        }
    }
}