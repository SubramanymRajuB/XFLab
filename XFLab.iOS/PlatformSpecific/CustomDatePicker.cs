using System;
using System.Globalization;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFLab.iOS.Renderers;

[assembly: ExportRenderer(typeof(DatePicker), typeof(CustomDatePicker))]
namespace XFLab.iOS.Renderers
{
    public class CustomDatePicker : DatePickerRenderer
    {
        DateTime? _selectedDate;
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && Control != null)
            {
                this.Control.Text = Element.Date.ToString("MM/dd/yy", CultureInfo.InvariantCulture)?.Replace("-", "/");

                Control.Layer.BorderWidth = 0f;
                Control.BorderStyle = UITextBorderStyle.None;
                //Control.Layer.BorderColor = UIColor.White.CGColor;
                //Control.Layer.BackgroundColor = UIColor.White.CGColor;
                Control.Layer.CornerRadius = 0f;

                UITextField entry = Control;
                UIDatePicker picker = (UIDatePicker)entry.InputView;
                picker.PreferredDatePickerStyle = UIDatePickerStyle.Wheels;

                //var dateTextField = (UITextField)Control;
                //DateFormatPicker _datePicker = new DateFormatPicker();
                //_selectedDate = Element.Date;
                //_datePicker.Configure(_selectedDate, dateTextField, "Done", "Clear", (DateTime? d) => SetDate(d));
            }
        }

    }

}

