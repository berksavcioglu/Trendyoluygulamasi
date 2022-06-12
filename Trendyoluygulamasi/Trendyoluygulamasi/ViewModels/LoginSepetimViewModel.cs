using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Trendyoluygulamasi.Models;
using System.Linq;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.Extensions;
using Xamarin.Forms;


namespace Trendyoluygulamasi.ViewModels
{
    public class LoginSepetimViewModel : BaseViewModel
       
    {
        

        ObservableCollection<Sepetmodel> cartProducts;
        public decimal SumOfCart
        {
            get
            {
                return sumOfCart;
            }
            set
            {
                sumOfCart = value;
                OnPropertyChanged(nameof(SumOfCart));
            }
        }

        public ObservableCollection<Sepetmodel> CartProducts
        {
            get { return cartProducts; }
        }
        ObservableCollection<Ürünmodel> randomProducts;
        private decimal sumOfCart;

        public ObservableCollection<Ürünmodel> RandomProducts { get { return randomProducts; } }
        public LoginSepetimViewModel()
        {
            GetShuffleProducts();
            GetCartProduct();
            AddProduct = new Command(
                (product) =>
                {
                    SepetData.AddProduct((Ürünmodel)product);
                    UpdateCartCost();
                    OnPropertyChanged(nameof(SumOfCart));
                    OnPropertyChanged(nameof(CartProducts));
                    
                }

                );
            RemoveProduct = new Command(
                (product) =>
                {
                    SepetData.RemoveProduct((Ürünmodel)product);
                    UpdateCartCost();
                    OnPropertyChanged(nameof(SumOfCart));
                    OnPropertyChanged(nameof(CartProducts));

                }

                );

        }

        private void GetShuffleProducts()
        {
            var data = ÜrünData.GetProducts();
            data.Shuffle();
            randomProducts = data;
        }
        private void GetCartProduct()
        {
            cartProducts = SepetData.CreateCart();
            OnPropertyChanged(nameof(SumOfCart));


        }
        
        public void UpdateCartCost()
        {
            SumOfCart = 0;
            foreach (var item in CartProducts)
            {

                SumOfCart += item.Product.Fiyatı * item.Count;
            }
        }

        public Command AddProduct { get; set; }
        public Command RemoveProduct { get; set; }
    }
}