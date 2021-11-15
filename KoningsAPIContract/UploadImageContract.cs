using System;

namespace KoningsAPIContract
{
    public class UploadImageContract
    {
        public string UserID { get; set; }
        public string ProductID { get; set; }
        public string ImageAsBase64 { get; set; }
        public string AnotherThing { get; set; }
    }
}
