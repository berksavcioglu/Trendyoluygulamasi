using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Trendyoluygulamasi.Models;

namespace Trendyoluygulamasi.Data
{
    public static class SepetData
    {
        public static ObservableCollection<Sepetmodel> Products { get { return products; } }
        public static ObservableCollection<Sepetmodel> products;

        public static ObservableCollection<Sepetmodel> CreateCart()
        {
            if (products == null)
            {
                products = new ObservableCollection<Sepetmodel>();
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
            Products.Add(new Sepetmodel()
            {
                Product = product
            });

        }
        public static bool AlreadyExists(Sepetmodel sepetModel)
        {

            return sepetModel != null ? false : true;
        }
        public static bool IsNotEmpty()
        {
            return Products.Count != 0 ? true : false;
        }

    }

}