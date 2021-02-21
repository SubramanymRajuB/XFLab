using System.ComponentModel;
using System.Globalization;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFLab.Controls;
using XFLab.Droid.PlatformSpecifics;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace XFLab.Droid.PlatformSpecifics
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        public CustomDatePickerRenderer(Context context) : base(context)
        {
        }

        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null && Control != null)
            {
                this.Control.SetTextColor(Android.Graphics.Color.Rgb(83, 63, 149));
                this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                this.Control.SetPadding(20, 0, 0, 0);

                GradientDrawable gd = new GradientDrawable();
                gd.SetCornerRadius(25); //increase or decrease to changes the corner look  
                gd.SetColor(Android.Graphics.Color.Transparent);
                gd.SetStroke(3, Android.Graphics.Color.Rgb(83, 63, 149));

                this.Control.Background = gd;
                Element.HeightRequest = 40;

                var entry = (CustomDatePicker)this.Element;
                this.Control.Text = !entry.NullableDate.HasValue ? entry.PlaceHolder : Element.Date.ToString(Element.Format);

                //this.Control.Text = Element.Date.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)?.Replace("-", "/");

            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Xamarin.Forms.DatePicker.DateProperty.PropertyName || e.PropertyName == Xamarin.Forms.DatePicker.FormatProperty.PropertyName)
            {
                var entry = (CustomDatePicker)this.Element;

                if (this.Element.Format == entry.PlaceHolder)
                {
                    this.Control.Text = entry.PlaceHolder;
                    return;
                }
            }

            base.OnElementPropertyChanged(sender, e);
        }
    }
}
