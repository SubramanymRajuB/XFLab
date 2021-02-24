using System;
using System.Threading.Tasks;
using XFLab.Models;

namespace XFLab.PlatformSpecific
{
    public interface IPayCardRecognizerService
    {
        Task<PayCard> ScanAsync();
    }
}
