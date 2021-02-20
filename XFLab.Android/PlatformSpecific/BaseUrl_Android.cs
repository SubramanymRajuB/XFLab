using FormsGallery.XamlExamples;
using Xamarin.Forms;
using XFLab.Droid.Renderers;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace XFLab.Droid.Renderers
{
    public class BaseUrl_Android : IBaseUrl 
	{
		public string Get () 
		{
			return "file:///android_asset/";
		}
	}
}