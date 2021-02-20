using FormsGallery.XamlExamples;
using Foundation;
using Xamarin.Forms;
using XFLab.iOS.PlatformSpecifics;

[assembly: Dependency(typeof(BaseUrl_iOS))]

namespace XFLab.iOS.PlatformSpecifics
{
    public class BaseUrl_iOS : IBaseUrl 
	{
		public string Get () 
		{
			return NSBundle.MainBundle.BundlePath;
		}
	}
}