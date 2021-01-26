using Xamarin.Forms;
using XFLab.ViewModels;

namespace CollectionViewDemos.Views
{
    public partial class VerticalListDataTemplateSelectorPage : ContentPage
    {
        public VerticalListDataTemplateSelectorPage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewModel();
        }
    }
}
