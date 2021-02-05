using System;
using System.IO;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFLab.Helpers;

namespace XFLab.ViewModels
{
    public class LauncherViewModel : BaseViewModel
    {
        string fileAttachmentName;
        string fileAttachmentContents;

        string url = "ms-outlook://compose?to=subbu.balaraju@gmail.com,revanth@gmail.com&subject=subject&body=body";
        public string LaunchUri
        {
            get => url;
            set {
                url = value;
            }
        }

        public ICommand LaunchCommand { get; }

        public ICommand CanLaunchCommand { get; }

        public ICommand LaunchMailCommand { get; }

        public ICommand LaunchBrowserCommand { get; }

        public ICommand LaunchFileCommand { get; }

        public LauncherViewModel()
        {
            LaunchCommand = new Command(OnLaunch);
            LaunchMailCommand = new Command(OnLaunchMail);
            LaunchBrowserCommand = new Command(OnLaunchBrowser);
            CanLaunchCommand = new Command(CanLaunch);
            LaunchFileCommand = new Command<Xamarin.Forms.View>(OnFileRequest);
        }

        public string FileAttachmentContents
        {
            get => fileAttachmentContents;
            set => SetProperty(ref fileAttachmentContents, value);
        }

        public string FileAttachmentName
        {
            get => fileAttachmentName;
            set => SetProperty(ref fileAttachmentName, value);
        }

        async void OnLaunchBrowser()
        {
            await Launcher.OpenAsync("https://github.com/xamarin/Essentials");
        }

        async void OnLaunch()
        {
            try
            {
                await Launcher.OpenAsync(LaunchUri);
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync($"Uri {LaunchUri} could not be launched: {ex}");
            }
        }

        async void OnLaunchMail()
        {
            await Launcher.OpenAsync("mailto:");
            //gmailUrl = URL(string: "googlegmail://co?to=\(to)&subject=\(subjectEncoded)&body=\(bodyEncoded)")
            //outlookUrl = URL(string: "ms-outlook://compose?to=\(to)&subject=\(subjectEncoded)")
            //yahooMail = URL(string: "ymail://mail/compose?to=\(to)&subject=\(subjectEncoded)&body=\(bodyEncoded)")
            //sparkUrl = URL(string: "readdle-spark://compose?recipient=\(to)&subject=\(subjectEncoded)&body=\(bodyEncoded)")
            //defaultUrl = URL(string: "mailto:\(to)?subject=\(subjectEncoded)&body=\(bodyEncoded)")
            //"mailto://to=subbu.balaraju@gmail.com,revanth@gmail.com&subject=subject&body=body
            //await Launcher.OpenAsync("mailto://to=subbu.balaraju@gmail.com,revanth@gmail.com?subject=subject&body=body");
        }

        async void CanLaunch()
        {
            try
            {
                var canBeLaunched = await Launcher.CanOpenAsync(LaunchUri);
                await DisplayAlertAsync($"Uri {LaunchUri} can be launched: {canBeLaunched}");
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync($"Uri {LaunchUri} could not be verified as launchable: {ex}");
            }
        }

        async void OnFileRequest(Xamarin.Forms.View element)
        {
            if (!string.IsNullOrWhiteSpace(FileAttachmentContents))
            {
                // create a temprary file
                var fn = string.IsNullOrWhiteSpace(FileAttachmentName) ? "Attachment.txt" : FileAttachmentName.Trim();
                var file = Path.Combine(FileSystem.CacheDirectory, fn);
                File.WriteAllText(file, FileAttachmentContents);

                var rect = element.GetAbsoluteBounds().ToSystemRectangle();
                rect.Y += 40;
                await Launcher.OpenAsync(new OpenFileRequest
                {
                    File = new ReadOnlyFile(file)
                });
            }
        }
    }
}
