using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Cards.Pay.Paycardsrecognizer.Sdk;
using Xamarin.Forms;
using XFLab.Droid.PlatformSpecific;
using XFLab.Models;
using XFLab.PlatformSpecific;

[assembly: Dependency(typeof(PayCardRecognizerService))]
namespace XFLab.Droid.PlatformSpecific
{
    public class PayCardRecognizerService : IPayCardRecognizerService
    {
        static TaskCompletionSource<PayCard> _cardTcs;
        static int _requestCodeScanCard = 1734;
        Activity _activity;

        public static void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (requestCode == _requestCodeScanCard)
            {
                if (resultCode == Result.Ok)
                {
                    Card card = data.GetParcelableExtra(ScanCardIntent.ResultPaycardsCard).JavaCast<Card>();

                    _cardTcs.TrySetResult(new PayCard()
                    {
                        HolderName = card.CardHolderName,
                        CardNumber = card.CardNumber,
                        ExpirationDate = card.ExpirationDate
                    });
                }
                else
                {
                    _cardTcs.TrySetCanceled();
                }
            }
        }

        public PayCardRecognizerService()
        {
            _activity = (Activity)App.ParentWindow;
            _requestCodeScanCard = 1734;

        }

        public async Task<PayCard> ScanAsync()
        {
            _cardTcs = new TaskCompletionSource<PayCard>();
            Intent intent = new ScanCardIntent.Builder(_activity).Build();
            _activity.StartActivityForResult(intent, _requestCodeScanCard);
            return await _cardTcs.Task;
        }
    }
}
