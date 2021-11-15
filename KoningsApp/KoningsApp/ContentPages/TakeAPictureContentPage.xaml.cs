using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoningsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoningsApp.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TakeAPictureContentPage : ContentPage
    {
        public TakeAPictureContentPage()
        {
            InitializeComponent();

            BindingContext = new TakeAPictureViewModel();

        }
    }
}