using System;
using KoningsApp.ContentPages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoningsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginContentPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
