using Xamarin.Forms;
using XFLab.ViewModels;

namespace Xaminals.Views
{
    public partial class MonkeyDetailPage : ContentPage
    {
        public MonkeyDetailPage()
        {
            InitializeComponent();
            BindingContext = new ShellMonkeyDetailViewModel();
        }
    }
}
