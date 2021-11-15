using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KoningsApp.Models
{
    public class TakeAPictureModel : INotifyPropertyChanged
    {
        public string PathToImageFile { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;


    }
}
