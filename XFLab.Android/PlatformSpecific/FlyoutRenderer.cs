using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFLab.Droid.PlatformSpecific;

[assembly: ExportRenderer(typeof(FlyoutPage), typeof(FlyoutRenderer))]
namespace XFLab.Droid.PlatformSpecific
{
    public class FlyoutRenderer: FlyoutPageRenderer
    {
        public FlyoutRenderer(Context context) : base(context)
        {
            //SetDrawerLockMode(DrawerLayout.LockModeLockedClosed);
        }

        protected override void OnElementChanged(VisualElement oldElement, VisualElement newElement)
        {
            base.OnElementChanged(oldElement, newElement);

            var flyoutPage = (this as IVisualElementRenderer).Element;
            if (flyoutPage != null)
            {
                var page = flyoutPage as FlyoutPage;
                SetDrawerLockMode(page.IsGestureEnabled ? LockModeUnlocked : LockModeLockedClosed);
            }

        }
    }
}
