using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using KoningsApp.ContentPages;
using KoningsApp.Models;
using Xamarin.Forms;

namespace KoningsApp.ViewModels
{
    public class Page1ViewModel
    {
        private readonly INavigation _navigation;
        public Page1Model Model { get; set; }

        public ICommand ValidateCommand { get; set; }

        public Page1ViewModel(INavigation navigation)
        {
            _navigation = navigation;
            Model = new Page1Model();
            ValidateCommand = new Command(ExecuteValidateCommand);
        }

        private void ExecuteValidateCommand()
        {
            var isValid = false;
            bool ageIsNumeric = int.TryParse(Model.Age, out var age);
            if (ageIsNumeric)
            {
                if (age < 100)
                {
                    isValid = true;
                }
            }

            if (!isValid)
            {
                Application.Current.MainPage.DisplayAlert("Konings", "is not valid", "ok");
            }
            else
            {
                _navigation.PushAsync(new Page2ContentPage());
            }
        }
    }
}
