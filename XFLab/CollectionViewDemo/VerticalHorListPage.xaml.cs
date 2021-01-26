using Xamarin.Forms;
using XFLab.ViewModels;

namespace CollectionViewDemos.Views
{
    public partial class VerticalHorListPage : ContentPage
    {
        public VerticalHorListPage()
        {
            InitializeComponent();
            BindingContext = new CollectionViewModel();
        }

        void OnEmptyViewSwitchToggled(object sender, ToggledEventArgs e)
        {
            ToggleEmptyView((sender as Switch).IsToggled);
        }

        void ToggleEmptyView(bool isToggled)
        {
            collectionView.EmptyView = isToggled ? Resources["BasicEmptyView"] : Resources["AdvancedEmptyView"];
        }
    }
}
