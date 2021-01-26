using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class DatabindingDemo : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public DatabindingDemo()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            BindingContext = this;
        }
    }
}
