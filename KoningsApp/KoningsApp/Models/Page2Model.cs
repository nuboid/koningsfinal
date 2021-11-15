using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using KoningsApp.Data;

namespace KoningsApp.Models
{
    public class Page2Model : INotifyPropertyChanged
    {
        public List<Product> Products { get; set; }
        public string SelectedImageSource { get; set; }
        public string TextAboveImage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
