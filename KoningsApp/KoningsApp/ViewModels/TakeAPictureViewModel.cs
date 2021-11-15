using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using KoningsAPIContract;
using KoningsApp.Fw;
using KoningsApp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace KoningsApp.ViewModels
{
    public class TakeAPictureViewModel
    {
        public TakeAPictureModel Model { get; set; }
        public Command TakePictureCommand { get; set; }
        public TakeAPictureViewModel()
        {
            Model = new TakeAPictureModel();
            TakePictureCommand = new Command(ExecuteTakePictureCommand);
        }

        private async void ExecuteTakePictureCommand()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                
                var ms = new MemoryStream();
                using (var stream = await photo.OpenReadAsync())
                    await stream.CopyToAsync(ms);
                var bytes = ms.ToArray();

                var documentsPath = DependencyService.Get<ILocalFileSystem>().GetExternalPath();
                var picturePath = documentsPath + "/takepicture.jpg";
                File.WriteAllBytes(picturePath, bytes);
                Model.PathToImageFile = picturePath;


                var base64 = Convert.ToBase64String(bytes);
                var client = Refit.RestService.For<IUploadImageController>("http://localhost:5000");
                await client.Test();
                await client.Upload(new UploadImageContract
                {
                    UserID = "u1",
                    ProductID = "p1",
                    ImageAsBase64 = base64,
                    AnotherThing = "sldhfskdhfk"
                });
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }
    }
}
