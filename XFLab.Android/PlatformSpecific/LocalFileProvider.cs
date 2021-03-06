﻿using System;
using System.IO;
using System.Threading.Tasks;
using Android.Content;
using Android.Net;
using Xamarin.Forms;
using XFLab.Droid.PlatformSpecifics;
using XFLab.PlatformSpecific;

[assembly: Dependency(typeof(LocalFileProvider))]

namespace XFLab.Droid.PlatformSpecifics
{
    public class LocalFileProvider : ILocalFileProvider
    {
        //private readonly string _rootDir = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "XFLAB_PDFList");
        readonly string _rootDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XFLAB_PDFList");

        public async Task<string> SaveFileToDiskAsync(Stream pdfStream, string fileName)
        {
            if (!Directory.Exists(_rootDir))
                Directory.CreateDirectory(_rootDir);

            var filePath = Path.Combine(_rootDir, fileName);

            using (var memoryStream = new MemoryStream())
            {
                await pdfStream.CopyToAsync(memoryStream);
                File.WriteAllBytes(filePath, memoryStream.ToArray());
            }

            return filePath;
        }
    }
}
