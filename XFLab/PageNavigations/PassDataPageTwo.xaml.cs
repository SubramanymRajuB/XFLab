using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFLab.PageNavigations
{
    public partial class PassDataPageTwo : ContentPage
    {
        public static Contact _contact;
        public PassDataPageTwo(Contact _contact = null)
        {
            InitializeComponent();
            if (_contact != null)
            {
                this.BindingContext = _contact;
            }
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
            Preferences.Set("TestPref", "You are successfully passed data.");
            MessagingCenter.Send<object, string>(this, "MSG_TEST", "Page Two");
        }
    }
}
