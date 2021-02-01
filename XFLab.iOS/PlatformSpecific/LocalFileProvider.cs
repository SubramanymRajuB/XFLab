using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFLab.iOS.PlatformSpecifics;
using XFLab.PlatformSpecific;

[assembly: Dependency(typeof(LocalFileProvider))]
namespace XFLab.iOS.PlatformSpecifics
{
    public class LocalFileProvider : ILocalFileProvider
    {
        private readonly string _rootDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "XFLAB_PDFList");

        public async Task<string> SaveFileToDiskAsync(Stream stream, string fileName)
        {
            if (!Directory.Exists(_rootDir))
                Directory.CreateDirectory(_rootDir);

            var filePath = Path.Combine(_rootDir, fileName);

            using (var memoryStream = new MemoryStream())
            {
                await stream.CopyToAsync(memoryStream);
                File.WriteAllBytes(filePath, memoryStream.ToArray());
            }

            return filePath;
        }
    }
}
