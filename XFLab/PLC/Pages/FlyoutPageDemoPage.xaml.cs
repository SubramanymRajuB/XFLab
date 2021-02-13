using System.Collections;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public partial class FlyoutPageDemoPage : FlyoutPage
    {
        public FlyoutPageDemoPage()
        {
            InitializeComponent();

            listView.SelectedItem = (listView.ItemsSource as IList)?[0];
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Show the detail page.
            IsPresented = false;


            //var item = e.SelectedItem as FlyoutPageItem;
            //if (item != null)
            //{
            //    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            //    flyoutPage.listView.SelectedItem = null;
            //    IsPresented = false;
            //}
        }
    }
}