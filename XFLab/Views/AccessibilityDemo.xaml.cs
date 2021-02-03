using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class AccessibilityDemo : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public AccessibilityDemo()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
    }
}
