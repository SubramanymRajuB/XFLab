using System.Linq;
using Plugin.Multilingual;
using Xamarin.Forms;
using XFLab.Localization;
using XFLab.Views;

namespace XFLab
{
    public partial class ChangeLanguagePage : ContentPage
    {
        public ChangeLanguagePage()
        {
            InitializeComponent();
            picker.Items.Add("English");
            picker.Items.Add("Spanish");
            picker.Items.Add("Portuguese");
            picker.Items.Add("French");
            picker.SelectedItem = CrossMultilingual.Current.CurrentCultureInfo.EnglishName;
        }

         async void OnUpdateLangugeClicked(object sender, System.EventArgs e)
        {

            CrossMultilingual.Current.CurrentCultureInfo = CrossMultilingual.Current.NeutralCultureInfoList.ToList().First(element => element.EnglishName.Contains(picker.SelectedItem.ToString()));
			AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
            await Navigation.PopAsync();
        }
    }
}
