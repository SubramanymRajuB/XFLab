
using Xamarin.Forms;
using XFLab.FilesDemo;

namespace XFLab.Views
{
    public partial class FilesDemo : ContentPage
    {
        public FilesDemo()
        {
            InitializeComponent();
        }

        void WriteRead_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SaveAndLoadText());
        }

        void XMLDemo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoadResourceXml());
        }

        void JSON_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoadResourceJson());
        }

        void PDF_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PDFDetails());
        }
    }
}
