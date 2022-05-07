using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Trendyoluygulamasi.Models;

namespace Trendyoluygulamasi.Data
{
    public static class CartData
    {
        public static ObservableCollection<Cartmodel> Products { get { return products; } }
        public static ObservableCollection<Cartmodel> products;

        public static ObservableCollection<Cartmodel> CreateCart()
        {
            if (products == null)
            {
                products = new ObservableCollection<Cartmodel>();
            }
            return Products;
        }

        public static void AddProduct(Ürünmodel product)
        {
            var data = Products.Where(c => c.Product.ÜrünId == product.ÜrünId).SingleOrDefault();
            if (!AlreadyExists(data))
            {
                data.Count += 1;
                return;
            }
            Products.Add(new Cartmodel()
            {
                Product = product
            });

        }
        public static bool AlreadyExists(Cartmodel cartModel)
        {

            return cartModel != null ? false : true;
        }
        public static bool IsNotEmpty()
        {
            return Products.Count != 0 ? true : false;
        }

    }

}