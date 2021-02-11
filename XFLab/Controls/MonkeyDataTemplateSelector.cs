using Xamarin.Forms;
using XFLab.Models;

namespace XFLab.Controls
{
    public class MonkeyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate AmericanMonkey { get; set; }
        public DataTemplate OtherMonkey { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Animal)item).Location.Contains("America") ? AmericanMonkey : OtherMonkey;
        }
    }
}
