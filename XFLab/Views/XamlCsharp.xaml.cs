using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class XamlCsharp : ContentPage
    {
        //Entry entry;
        public XamlCsharp()
        {
            InitializeComponent();

            StackLayout stck = new StackLayout();
            stck.Margin = new Thickness(20);
            stck.VerticalOptions = LayoutOptions.Center;
            //this.Content = stck;
            //this.Title = "XAML vs C#";

            //Create Entry
            //entry = new Entry();
            //entry.Text = "Welcome to Xamarin";
            //entry.FontSize = 27;
            //stck.Children.Add(entry);

            //Create Button
            Button btn = new Button();
            btn.BackgroundColor = Color.FromHex("#abcabc");
            btn.Text = "Submit";
            btn.HorizontalOptions = LayoutOptions.FillAndExpand;
            btn.Clicked += Button_Clicked;
            stck.Children.Add(btn); 

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        bool isBackAllow = true;
        protected override bool OnBackButtonPressed()
        {
            if (!isBackAllow)
            {
                return true;
            }
            else
            {
                base.OnBackButtonPressed();
                return false;
            }
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("", entry.Text, "Ok");
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
    }
}
