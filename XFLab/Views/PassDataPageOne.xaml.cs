using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFLab.Models;
using XFLab.PageNavigations;

namespace XFLab.Views
{
    public partial class PassDataPageOne : ContentPage
    {
		List<Contact> contacts;
		public PassDataPageOne()
        {
            InitializeComponent();

			MessagingCenter.Subscribe<Object, string>(this, "MSG_TEST", async (sender, arg) =>
			{
				var checkValue = Preferences.Get("TestPref", "");
				await DisplayAlert("", "You came from = " + arg, "OK");
				await DisplayAlert("", "Preferences Value: = " + checkValue, "OK");
			});

			SetupData();
			listView.ItemsSource = contacts;
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (listView.SelectedItem != null)
			{
				var _contact = e.SelectedItem as Contact;

				//Pass data using BindingContext
				var detailPage = new PassDataPageTwo();
				detailPage.BindingContext = _contact;
				await Navigation.PushModalAsync(detailPage);

				//Pass data using constructor
				//await Navigation.PushModalAsync(new PassDataPageTwo(_contact));

				//Pass data using static object
				PassDataPageTwo._contact = _contact;
				//await Navigation.PushModalAsync(new PassDataPageTwo());

				//Reset listview selection
				listView.SelectedItem = null;
			}
		}

		void SetupData()
		{
			contacts = new List<Contact>();
			contacts.Add(new Contact
			{
				Name = "Jane Doe",
				Age = 30,
				Occupation = "Developer",
				Country = "USA"
			});
			contacts.Add(new Contact
			{
				Name = "John Doe",
				Age = 34,
				Occupation = "Tester",
				Country = "USA"
			});
			contacts.Add(new Contact
			{
				Name = "John Smith",
				Age = 52,
				Occupation = "PM",
				Country = "UK"
			});
			contacts.Add(new Contact
			{
				Name = "Kath Smith",
				Age = 55,
				Occupation = "Business Analyst",
				Country = "UK"
			});
			contacts.Add(new Contact
			{
				Name = "Steve Smith",
				Age = 19,
				Occupation = "Junior Developer",
				Country = "UK"
			});
		}
	}
}
