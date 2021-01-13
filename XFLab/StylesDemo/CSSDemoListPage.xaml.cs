using Xamarin.Forms;
using MonkeyApp.ViewModels;
using MonkeyApp.Models;

namespace Styles
{
    public partial class CSSDemoListPage : ContentPage
    {
        public CSSDemoListPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysPageViewModel();
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as Monkey;
            if (monkey != null)
            {
                var page = new CSSDemoDetailsPage();
                page.BindingContext = monkey;
                await Navigation.PushAsync(page);
            }
        }
    }
}

