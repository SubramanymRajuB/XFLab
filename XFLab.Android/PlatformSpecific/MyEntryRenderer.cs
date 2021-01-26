using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFLab.Droid.Renderers;
using XFLab.PlatformSpecific;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace XFLab.Droid.Renderers
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                this.Control.SetPadding(10, 20, 10, 20);

                var nativeEntryEditText = Control as FormsEditText;
                nativeEntryEditText.InputType = Android.Text.InputTypes.ClassText | Android.Text.InputTypes.TextFlagCapSentences;
            }
        }
    }
}
