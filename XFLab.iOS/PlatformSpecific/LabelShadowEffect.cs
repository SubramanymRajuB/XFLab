using System;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(XFLab.iOS.LabelShadowEffect), nameof(XFLab.iOS.LabelShadowEffect))]
namespace XFLab.iOS
{
    public class LabelShadowEffect : PlatformEffect
	{
		protected override void OnAttached ()
		{
			try {
				Control.Layer.CornerRadius = 5;
				Control.Layer.ShadowColor = Color.Black.ToCGColor ();
				Control.Layer.ShadowOffset = new CGSize (5, 5);
				Control.Layer.ShadowOpacity = 1.0f;
			} catch (Exception ex) {
				Console.WriteLine ("Cannot set property on attached control. Error: ", ex.Message);
			}
		}

		protected override void OnDetached ()
		{
		}
	}
}
