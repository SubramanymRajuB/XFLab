using ListAndCollectionViewDemos;
using Xamarin.Forms;

namespace XFLab.Views
{
    public partial class ListViewDemoPage : ContentPage
    {
        public ListViewDemoPage()
        {
            InitializeComponent();
        }

        async void BuiltinCell_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BuiltInCell());
        }

        async void CustomCell_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CustomCell());
        }

        async void Grouping_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GroupedListXaml());
        }

        async void Interactivity_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Interactivity());
        }
    }
}
