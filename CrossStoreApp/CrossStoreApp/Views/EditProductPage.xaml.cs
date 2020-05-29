﻿using CrossStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossStoreApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProductPage : ContentPage
    {
        private Product product;

        public EditProductPage(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void FillFields(Product product)
        {
            EntryName.Text = product.Name;
            EntryPhoto.Text = product.Photo;
            EntryPrice.Text = product.Price.ToString();
        }

        private void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            var name = EntryName.Text;
            var photo = EntryPhoto.Text;
            Decimal price = 0;
            if (!Decimal.TryParse(EntryPrice.Text, out price))
            {
                DisplayAlert("Invalid Price", "Please, type a valid price", "Ok");
                return;
            }

            product.Name = name;
            product.Photo = photo;
            product.Price = price;

            App.Service.UpdateProduct(product);
            Navigation.PopModalAsync(true);
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}