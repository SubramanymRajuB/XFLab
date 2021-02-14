using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class MarkupExtensionDemo : ContentPage
    {
        public MarkupExtensionDemo()
        {
            InitializeComponent();
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }

        public ICommand NavigateCommand { private set; get; }
    }
}
