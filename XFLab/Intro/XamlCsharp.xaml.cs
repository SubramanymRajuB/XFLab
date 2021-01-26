using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.Intro
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
    }
}
