using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFLab.iOS.Renderers;
using XFLab.PlatformSpecific;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace XFLab.iOS.Renderers
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.BorderStyle = UITextBorderStyle.Line;
				Control.Layer.BorderColor = UIColor.Red.CGColor;
				Control.Layer.BorderWidth = 1;
			}
		}
	}
}
