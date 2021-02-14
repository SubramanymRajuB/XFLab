using Xamarin.Forms;
using XFLab;

namespace ListAndCollectionViewDemos
{
    public partial class BuiltInCell : ContentPage
    {
        public BuiltInCell()
        {
            InitializeComponent();
            listView.ItemsSource = AppConstants.Veggies;
        }
    }
}