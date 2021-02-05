using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFLab.Droid.Renderers;
using XFLab.PlatformSpecific;

[assembly: ExportRenderer(typeof(Editor), typeof(CustomEditorRenderer))]
namespace XFLab.Droid.Renderers
{
    class CustomEditorRenderer : EditorRenderer
    {
        public CustomEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var nativeEditText = (global::Android.Widget.EditText)Control;
                var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                shape.Paint.Color = Xamarin.Forms.Color.Blue.ToAndroid();
                shape.Paint.SetStyle(Paint.Style.Stroke);
                shape.Paint.StrokeWidth = 5;
                nativeEditText.Background = shape;
                nativeEditText.InputType = Android.Text.InputTypes.ClassText | Android.Text.InputTypes.TextFlagCapSentences;
            }
        }
    }
}
