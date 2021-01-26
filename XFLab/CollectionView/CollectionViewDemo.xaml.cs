using CollectionViewDemos.Views;
using Xamarin.Forms;
using XFLab.CollectionView;

namespace XFLab.Views
{
    public partial class CollectionViewDemo : ContentPage
    {
        public CollectionViewDemo()
        {
            InitializeComponent();
        }

        void BtnLayoutOrientation_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VerticalHorListPage());
        }

        void BtnTemplateSelector_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VerticalListDataTemplateSelectorPage());
        }

        void BtnGrouping_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VerticalListGroupingPage());
        }

        void BtnContextMenu_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SwipeContextItemsPage());
        }
    }
}
