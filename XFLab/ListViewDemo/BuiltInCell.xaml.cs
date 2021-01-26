using Xamarin.Forms;

namespace ListAndCollectionViewDemos
{
    public partial class BuiltInCell : ContentPage
    {
        public BuiltInCell()
        {
            InitializeComponent();
            listView.ItemsSource = Constants.Veggies;
        }
    }
}