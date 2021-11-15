using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KoningsApp.Models
{
    public class Page1Model : INotifyPropertyChanged
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Age { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
       
    }
}
