using System;
using Xamarin.Forms;

namespace XFLab.PlatformSpecific
{
    public class EntryEffect : RoutingEffect
    {
        public EntryEffect() : base($"MyCompany.{nameof(EntryEffect)}")
        {
        }
    }
}
