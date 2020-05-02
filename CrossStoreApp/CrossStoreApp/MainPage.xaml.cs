using CrossStoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CrossStoreApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private static bool flashLightOn = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnCliqueAqui_Clicked(object sender, EventArgs e)
        {
            if (flashLightOn)
            {
                await Flashlight.TurnOffAsync();
                flashLightOn = false;
            }
            else
            {
                await Flashlight.TurnOnAsync();
                flashLightOn = true;
            }
                

            // Turn Off
            

            var products = new List<Product>();
            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Samsung Tab S6",
                Photo = String.Empty,
                Price = 3000
            }) ;

            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Dell G7",
                Photo = String.Empty,
                Price = 5000
            });

            ListProducts(products);
        }

        private void ListProducts(List<Product> products)
        {
            foreach(var product in products)
            {
                var lblName = new Label
                {
                    Text = product.Name
                };
                StackLayoutProducts.Children.Add(lblName);
            }
        }
    }
}
