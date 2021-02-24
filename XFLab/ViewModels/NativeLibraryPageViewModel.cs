using System;
using System.Windows.Input;
using Xamarin.Forms;
using XFLab.PlatformSpecific;

namespace XFLab.ViewModels
{
    public class NativeLibraryViewModel
    {
        public NativeLibraryViewModel()
        {
        }

        public ICommand ScanCommand
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {

                        var card = await DependencyService.Get<IPayCardRecognizerService>().ScanAsync();
                          //var card = await _payCardRecognizerService.ScanAsync();
                        await App.Current.MainPage.DisplayAlert("Result", $"{card.HolderName}\n{card.CardNumber}\n{card.ExpirationDate}", "Ok");
                    }
                    catch (Exception ex)
                    {
                        await App.Current.MainPage.DisplayAlert("Oops!", "Error Reading Card.", "Ok");
                    }

                });
            }
        }
    }
}
