using System;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public partial class DatePickerDemoPage : ContentPage
    {
        public DatePickerDemoPage()
        {
            InitializeComponent();
            BindingContext = this;
        }


        DateTime? _selectedDate = null;
        public DateTime? SelectedDate
        {
            get => _selectedDate;
            set
            {
                _selectedDate = value;
            }
        }
    }
}