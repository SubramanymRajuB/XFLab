using Xamarin.Forms;
using XFLab.ViewModels;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListGroupingPage : ContentPage
    {
        public VerticalListGroupingPage()
        {
            InitializeComponent();
            BindingContext = new CollectionGroupingViewModel();
        }
    }
}
