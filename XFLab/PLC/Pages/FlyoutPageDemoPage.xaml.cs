using System.Collections;
using Xamarin.Forms;

namespace FormsGallery.XamlExamples
{
    public partial class FlyoutPageDemoPage : FlyoutPage
    {
        public FlyoutPageDemoPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<object, int>(this, "LABEL_DEMO", async (sender, arg) =>
            {
                if (arg==2)
                {
                    listView.SelectedItem = (listView.ItemsSource as IList)?[arg];
                }
            });

            if (Device.RuntimePlatform == Device.Android)
            {
                //IsPresentedChanged += (s, e) =>
                //{
                //    if (IsPresented) return;

                //    IsGestureEnabled = true;
                //    IsGestureEnabled = false;
                //};
            }
            else
            {
                IsGestureEnabled = false;
            }

            listView.SelectedItem = (listView.ItemsSource as IList)?[0];
            btnTest.Clicked += BtnTest_Clicked;
        }

        async void BtnTest_Clicked(object sender, System.EventArgs e)
        {
            IsGestureEnabled = !IsGestureEnabled;
            //await Navigation.PushAsync(new LabelDemoPage());
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