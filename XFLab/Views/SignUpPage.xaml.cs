using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
