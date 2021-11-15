using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoningsAPIContract;
using System.IO;
namespace KoningsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageController :  ControllerBase, IUploadImageController
    {
        [HttpGet]
        [Route("test")]
        public async Task<bool> Test()
        {
            Console.WriteLine("Test");
            return await Task.FromResult(true);
        }

        [HttpPost]
        [Route("postimage")]
        public async Task<Boolean> Upload([FromBody] UploadImageContract request)
        {
            Console.WriteLine("Upload");
            var bytes2 = Convert.FromBase64String(request.ImageAsBase64);
            await System.IO.File.WriteAllBytesAsync(@"C:\tmp\Foto\takepicture_fromAPI.jpg", bytes2);
            return await Task.FromResult(true);
        }
    }
}
