using Xamarin.Forms;
using XFLab.ViewModels;

namespace XFLab.CollectionView
{
    public partial class SwipeContextItemsPage : ContentPage
    {
        public SwipeContextItemsPage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewModel();
        }
    }
}
