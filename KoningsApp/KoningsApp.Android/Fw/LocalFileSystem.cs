using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KoningsApp.Droid.Fw;
using KoningsApp.Fw;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalFileSystem))]
namespace KoningsApp.Droid.Fw
{
    public class LocalFileSystem : ILocalFileSystem
    {
        public string GetExternalPath()
        {
            Context context = global::Android.App.Application.Context;
            var documentsPath = context.GetExternalFilesDir(global::Android.OS.Environment.DirectoryDocuments).AbsolutePath;
            return documentsPath;
        }
    }
}