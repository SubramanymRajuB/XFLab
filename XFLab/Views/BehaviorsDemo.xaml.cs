using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class BehaviorsDemo : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }
        public BehaviorsDemo()
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
