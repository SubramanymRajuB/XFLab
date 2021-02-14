using Xamarin.Forms;

namespace XFLab.Controls
{
    public partial class ContentViewTemplate : ContentView
    {

        public static readonly BindableProperty PageTitleProperty = BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(ContentViewTemplate), string.Empty);
        public ContentViewTemplate()
        {
            InitializeComponent();
        }

        public string PageTitle
        {
            get => (string)GetValue(ContentViewTemplate.PageTitleProperty);
            set => SetValue(ContentViewTemplate.PageTitleProperty, value);
        }
        public View Body
        {
            get => BodyContent.Content;
            set => BodyContent.Content = value;
        }
        public View Footer
        {
            get => FooterContent.Content;
            set => FooterContent.Content = value;
        }
    }
}
