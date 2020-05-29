using CrossStore.Domain.Entities;
using CrossStore.Domain.Services;
using CrossStore.Infra.DataAccess.Repositories.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CrossStoreApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListProducts(App.Service.GetAllProducts());
        }

        public void ListProducts(IEnumerable<Product> products)
        {
            StackLayoutProducts.Children.Clear();

            foreach (var product in products)
            {
                var labelName = new Label();
                labelName.Text = $"{product.Name} - {product.Price}";

                var image = new Image();
                if (product.Photo != null)
                {
                    image.Source = ImageSource.FromUri(new Uri(product.Photo));
                    StackLayoutProducts.Children.Add(image);
                }

                StackLayoutProducts.Children.Add(labelName);
            }
        }

        private void BtAddProduct_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddProductPage(), true);
        }
    }
}
