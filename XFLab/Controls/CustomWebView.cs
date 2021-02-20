using System;
using Xamarin.Forms;

namespace XFLab.Controls
{
    public partial class CustomWebView : WebView
    {
        public static readonly BindableProperty ExpectedHieghtProperty = BindableProperty.Create(nameof(ExpectedHieght), typeof(double), typeof(CustomWebView), 0.0);
        
        public double ExpectedHieght
        {
            get => (double)GetValue(CustomWebView.ExpectedHieghtProperty);
            set => SetValue(CustomWebView.ExpectedHieghtProperty, value);
        }

        public event System.EventHandler LoadingStart;
        public event System.EventHandler LoadingFinished;

        public void InvokeCompleted()
        {
            if (this.LoadingFinished != null)
                this.LoadingFinished.Invoke(this, null);
        }
    }
}
