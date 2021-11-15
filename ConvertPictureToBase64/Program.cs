using System;
using System.IO;
using System.Threading.Tasks;
using KoningsAPIContract;

namespace ConvertPictureToBase64
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //App
            var bytes = File.ReadAllBytes(@"C:\tmp\Foto\takepicture.jpg");
            var base64 = Convert.ToBase64String(bytes);




            File.WriteAllText(@"C:\tmp\Foto\AsBase64.txt", base64);
            
            
            //Api
            Console.ReadKey();
            
            var client = Refit.RestService.For<IUploadImageController>("http://localhost:55269");
            await client.Test();
            await client.Upload(new UploadImageContract
            {
                UserID = "u1",
                ProductID = "p1",
                ImageAsBase64 = base64
            });


            //var bytes2 = Convert.FromBase64String(base64);
            //File.WriteAllBytes(@"C:\tmp\Foto\takepicture2.jpg", bytes2);
        }
    }
}
