using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace KoningsAPIContract
{
    public interface IUploadImageController
    {

        [Get("/api/UploadImage/test")]
        Task<Boolean> Test();

        [Post("/api/UploadImage/postimage")]
        Task<Boolean> Upload([Body] UploadImageContract request);
    }
}
