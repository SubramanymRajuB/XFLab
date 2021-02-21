using System;
using System.Collections.Generic;
using System.ComponentModel;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFLab.Controls;
using XFLab.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace XFLab.iOS.Renderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        DateTime? _selectedDate;
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && Control != null)
            {
                //this.Control.Text = Element.Date.ToString("MM/dd/yy", CultureInfo.InvariantCulture)?.Replace("-", "/");

                Control.BorderStyle = UITextBorderStyle.RoundedRect;
                Control.Layer.BorderColor = UIColor.FromRGB(83, 63, 149).CGColor;
                Control.Layer.CornerRadius = 20;
                UIView paddingView = new UIView(new CGRect(0, 0, 10.0f, 20.0f));
                Control.LeftView = paddingView;
                Control.Layer.BorderWidth = 0f;
                Control.AdjustsFontSizeToFitWidth = true;
                Control.TextColor = UIColor.FromRGB(83, 63, 149);

                var customDatePicker = (CustomDatePicker)this.Element;
                if (!customDatePicker.NullableDate.HasValue)
                {
                    this.Control.Text = customDatePicker.PlaceHolder;
                }

                UITextField entry = Control;
                UIDatePicker picker = (UIDatePicker)entry.InputView;
                picker.PreferredDatePickerStyle = UIDatePickerStyle.Wheels;

                CustomDatePicker baseDatePicker = this.Element as CustomDatePicker;
                this.Element.Unfocus();
                this.Element.Date = DateTime.Now;
                baseDatePicker.CleanDate();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Check if the property we are updating is the format property
            if (e.PropertyName == Xamarin.Forms.DatePicker.DateProperty.PropertyName || e.PropertyName == Xamarin.Forms.DatePicker.FormatProperty.PropertyName)
            {
                var entry = (CustomDatePicker)this.Element;

                // If we are updating the format to the placeholder then just update the text and return
                if (this.Element.Format == entry.PlaceHolder)
                {
                    this.Control.Text = entry.PlaceHolder;
                    return;
                }
            }

            base.OnElementPropertyChanged(sender, e);
        }

        private void AddClearButton()
        {
            var originalToolbar = this.Control.InputAccessoryView as UIToolbar;

            if (originalToolbar != null && originalToolbar.Items.Length <= 2)
            {
                var clearButton = new UIBarButtonItem("Clear", UIBarButtonItemStyle.Plain, ((sender, ev) =>
                {
                    CustomDatePicker baseDatePicker = this.Element as CustomDatePicker;
                    this.Element.Unfocus();
                    this.Element.Date = DateTime.Now;
                    baseDatePicker.CleanDate();

                }));

                var newItems = new List<UIBarButtonItem>();
                foreach (var item in originalToolbar.Items)
                {
                    newItems.Add(item);
                }

                newItems.Insert(0, clearButton);

                originalToolbar.Items = newItems.ToArray();
                originalToolbar.SetNeedsDisplay();
            }

        }
    }
}

