using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using KoningsApp.ContentPages;
using KoningsApp.Data;
using KoningsApp.Fw;
using KoningsApp.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace KoningsApp.ViewModels
{
    public class Page2ViewModel
    {
        private readonly INavigation _navigation;
        public Page2Model Model { get; set; }

        public Command ItemSelectedCommand { get; set; }
        public Command TappedOnImageCommand { get; set; }
        public Page2ViewModel(INavigation navigation)
        {
            _navigation = navigation;
            ItemSelectedCommand = new Command(ExecuteItemSelectedCommand);
            TappedOnImageCommand = new Command(ExecuteTappedOnImageCommand);
            //Hardcoded for now, data should come from API

            var listProducts = new List<Product>
            {
                new Product
                {
                    Id = "id1",
                    Name = "Bacardi Breezer",
                    Price = "89.56",

                    Image = "breezer.jpg",
                    Text = "Lorum ipsum",
                },
                new Product
                {
                    Id = "id2",
                    Name = "Ice Tea",
                    Price = "19.56",

                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/40/Sunflower_sky_backdrop.jpg",
                    Text = "Lorum ipsum",
                },
                new Product
                {
                    Id = "id3",
                    Name = "Duvel",
                    Price = "39.56",

                    Image = "duvel.jpg",
                    Text = "Lorum ipsum",
                }
            };

            var jsonToWrite = JsonConvert.SerializeObject(listProducts, Formatting.Indented);

            //var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var documentsPath = DependencyService.Get<ILocalFileSystem>().GetExternalPath();
            
            File.WriteAllText(documentsPath + "/products.txt", jsonToWrite);

            var jsonRead = File.ReadAllText(documentsPath + "/products.txt");

            var tmpModel = JsonConvert.DeserializeObject<List<Product>>(jsonRead);

            Model = new Page2Model
            {
                Products = tmpModel
            };
        }

        private void ExecuteTappedOnImageCommand()
        {
            _navigation.PushAsync(new TakeAPictureContentPage());
        }

        private void ExecuteItemSelectedCommand(object obj)
        {
            var selectedProduct = obj as Product;

            Model.TextAboveImage = selectedProduct.Text;
            Model.SelectedImageSource = selectedProduct.Image;


        }
    }
}
