using System;
using Xamarin.Forms;
using XFLab;

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
                                <img src='xamarinstore.jpg'/>
                                <p><a href=""local.html"">next page</a></p>
                                </body>
                                </html>";

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            webView.Source = htmlSource;


            webView.LoadingFinished += LoadingFinished;
        }

        private double width = 0;
        private double height = 0;

        //OnSizeAllocated method may be called many times when a device is rotated.
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;
                //reconfigure layout
            }
        }

        void LoadingFinished(object sender, EventArgs e)
        {
            SetActualHieght();
        }

        void SetActualHieght()
        {
            double isOutofScreen = height - dummyBtn.HeightRequest;
            if (webView.HeightRequest >= isOutofScreen)
            {
                webView.ExpectedHieght = isOutofScreen;
                OriginalBtn.IsVisible = false;
                dummyBtn.IsVisible = true;
            }
            else
            {
                OriginalBtn.IsVisible = true;
                dummyBtn.IsVisible = false;
            }
        }

        protected override void OnAppearing()
        {
            var t = parent.HeightRequest;
            var t1 = parent.Height;
            var test1 = GetScreenCoordinates(dummyBtn);
            var test2 = GetScreenCoordinates(OriginalBtn);
            var test3 = GetScreenCoordinates(webView);
            //var y = dummyBtn.Y;
            //var parentt = (VisualElement)dummyBtn.Parent;
            //var type = parent.Parent.GetType();
            //while (parent != null && parent.Parent.GetType() == typeof(VisualElement))
            //{
            //    y += parent.Y;
            //    parent = (VisualElement)parent.Parent;
            //}

            //var test = y;
            base.OnAppearing();
        }

        private (double X, double Y) GetScreenCoordinates(VisualElement view)
        {
            // A view's default X- and Y-coordinates are LOCAL with respect to the boundaries of its parent,
            // and NOT with respect to the screen. This method calculates the SCREEN coordinates of a view.
            // The coordinates returned refer to the top left corner of the view.

            // Initialize with the view's "local" coordinates with respect to its parent
            double screenCoordinateX = view.X;
            double screenCoordinateY = view.Y;

            // Get the view's parent (if it has one...)
            if (view.Parent.GetType() != typeof(App))
            {
                VisualElement parent = (VisualElement)view.Parent;


                // Loop through all parents
                while (parent != null)
                {
                    // Add in the coordinates of the parent with respect to ITS parent
                    screenCoordinateX += parent.X;
                    screenCoordinateY += parent.Y;

                    // If the parent of this parent isn't the app itself, get the parent's parent.
                    if (parent.Parent?.GetType() == typeof(App))
                        parent = null;
                    else
                        parent = (VisualElement)parent.Parent;
                }
            }

            // Return the final coordinates...which are the global SCREEN coordinates of the view
            return (screenCoordinateX, screenCoordinateY);
        }
    }
}