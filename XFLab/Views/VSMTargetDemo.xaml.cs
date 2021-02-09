using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class VSMTargetDemo : ContentPage
    {
        string _currentColorState = "Normal";
        public VSMTargetDemo()
        {
            InitializeComponent();

            CurrentState.Text = $"Current state: {_currentColorState}";
        }

        void ToggleValid_OnClicked(System.Object sender, System.EventArgs e)
        {
            if (_currentColorState == "Normal")
            {
                _currentColorState = "Invalid";
            }
            else
            {
                _currentColorState = "Normal";
            }

            CurrentState.Text = $"Current state: {_currentColorState}";
            VisualStateManager.GoToState(MyStackLayout, _currentColorState);
            VisualStateManager.GoToState(WelcomeLabel, _currentColorState);
            VisualStateManager.GoToState(ToggleValidButton, _currentColorState);
        }
    }
}
