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
    public partial class Page2ContentPage : ContentPage
    {
        public Page2ContentPage()
        {
            InitializeComponent();

            BindingContext = new Page2ViewModel(Navigation);
        }

       
    }
}