using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class RadioButtonChangesDemo : ContentPage
    {
        public RadioButtonChangesDemo()
        {
            InitializeComponent();
        }
        void OnAnimalRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            animalLabel.Text = $"You have chosen: {button.Value}";
        }
    }
}
