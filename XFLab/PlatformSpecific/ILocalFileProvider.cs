// --------------------------------------------------------------------------------------------------------------------
// <summary>
// Get device file path of saved documents
// </summary>
//--------------------------------------------------------------------------------------------------------------------

using System.IO;
using System.Threading.Tasks;

namespace XFLab.PlatformSpecific
{
    public interface ILocalFileProvider
    {
        //Pass pdf stream content and file name you want to store pdf
        Task<string> SaveFileToDiskAsync(Stream stream, string fileName);
    }
}
