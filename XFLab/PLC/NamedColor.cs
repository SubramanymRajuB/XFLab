using Xamarin.Forms;

namespace FormsGallery
{
    // Used in TabbedPageDemoPage, CarouselPageDemoPage & FlyoutPageDemoPage.
    public class NamedColor
    {
        public NamedColor()
        {
            ;
        }
        public NamedColor(string name, Color color, string img)
        {
            Name = name;
            Color = color;
            Image = img;
        }

        public string Name { set; get; }

        public string Image { set; get; }

        public Color Color { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }

}
