using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using XFLab;
using XFLab.Models;
//using Microsoft.AppCenter.Analytics;

namespace XFLab.Models
{
    public class LogAppAnalytics
    {
        public static void Capture(DateTime StartTime, string NavigationTo)
        {
            if (!string.IsNullOrEmpty(AppConstants.APP_ANALYTICS_ANDROID_KEY) && !string.IsNullOrEmpty(AppConstants.APP_ANALYTICS_IOS_KEY))
            {
                var ResponseTime = (DateTime.Now - StartTime).TotalMilliseconds.ToString("N0") + " milliseconds";
                Analytics.TrackEvent(NavigationTo, new Dictionary<string, string> {
                    { "User", "Subramanyam Raju" },
                    { "Country", "India"},
                    { "TimeToLoad", ResponseTime}
                });
            }
        }
    }
}
