using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFLab
{
    public class VersionTrackingDemo : ContentPage
    {
        public VersionTrackingDemo()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Version Tracking Values" }
                }
            };

            // First time ever launched application
            var firstLaunch = VersionTracking.IsFirstLaunchEver;

            // First time launching current version
            var firstLaunchCurrent = VersionTracking.IsFirstLaunchForCurrentVersion;

            // First time launching current build
            var firstLaunchBuild = VersionTracking.IsFirstLaunchForCurrentBuild;

            // Current app version (2.0.0)
            var currentVersion = VersionTracking.CurrentVersion;

            // Current build (2)
            var currentBuild = VersionTracking.CurrentBuild;

            // Previous app version (1.0.0)
            var previousVersion = VersionTracking.PreviousVersion;

            // Previous app build (1)
            var previousBuild = VersionTracking.PreviousBuild;

            // First version of app installed (1.0.0)
            var firstVersion = VersionTracking.FirstInstalledVersion;

            // First build of app installed (1)
            var firstBuild = VersionTracking.FirstInstalledBuild;

            // List of versions installed (1.0.0, 2.0.0)
            var versionHistory = VersionTracking.VersionHistory;

            // List of builds installed (1, 2)
            var buildHistory = VersionTracking.BuildHistory;
        }
    }
}

