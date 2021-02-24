//using System.Threading.Tasks;
//using Foundation;
//using PayCards;
//using UIKit;
//using Xamarin.Forms;
//using XFLab.iOS.PlatformSpecific;
//using XFLab.iOS.PlatformSpecifics;
//using XFLab.Models;
//using XFLab.PlatformSpecific;

//[assembly: Dependency(typeof(PayCardRecognizerService))]
//namespace XFLab.iOS.PlatformSpecifics
//{
//    public class PayCardRecognizerService : NSObject, IPayCardRecognizerService, IPayCardsRecognizerPlatformDelegate
//    {
//        TaskCompletionSource<PayCard> _cardTcs;
//        RecognizerViewController _recognizerViewController;

//        public PayCardRecognizerService()
//        {

//        }

//        [Export("payCardsRecognizer:didRecognize:")]
//        public void DidRecognize(PayCardsRecognizer payCardsRecognizer, PayCardsRecognizerResult result)
//        {
//            if (result.IsCompleted)
//            {
//                _cardTcs.TrySetResult(new PayCard()
//                {
//                    HolderName = result.RecognizedHolderName,
//                    CardNumber = result.RecognizedNumber,
//                    ExpirationDate = $"{result.RecognizedExpireDateMonth}/{result.RecognizedExpireDateYear}"
//                });

//                _recognizerViewController.DismissViewController(true, null);
//            }
           
//        }

//        public async Task<PayCard> ScanAsync()
//        {
//            _cardTcs = new TaskCompletionSource<PayCard>();
//            var window = UIApplication.SharedApplication.KeyWindow;
//            var _viewController = window.RootViewController;
//            while (_viewController.PresentedViewController != null)
//                _viewController = _viewController.PresentedViewController;


//             _recognizerViewController = new RecognizerViewController(this);
            
//             _viewController?.PresentViewController(_recognizerViewController, true, null);

//            return await _cardTcs.Task;

//        }

//    }
//}
