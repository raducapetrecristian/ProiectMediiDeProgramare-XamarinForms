﻿using System;
using System.Collections.Generic;
using Nume_Pren_Lab10.Models;
using Xamarin.Forms;

namespace Nume_Pren_Lab10
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveShopListAsync(slist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShopList)BindingContext;
            await App.Database.DeleteShopListAsync(slist);
            await Navigation.PopAsync();
        }

        async void OnChooseButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPage((ShopList)
 this.BindingContext)
            {
                BindingContext = new Product()
            });
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing(); var shopl = (ShopList)BindingContext;
            listView.ItemsSource = await App.Database.GetListProductsAsync(shopl.ID);
        }
    }
}