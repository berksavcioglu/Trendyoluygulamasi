using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Trendyoluygulamasi.Models;

namespace Trendyoluygulamasi.Data
{
    public static class ÜrünData
    {
        public static ObservableCollection<Ürünmodel> Products { get { return products; } }
        public static ObservableCollection<Ürünmodel> products;
        public static ObservableCollection<Ürünmodel> GetProducts()
        {
            if (products == null)
            {
                products = new ObservableCollection<Ürünmodel>
            {
                new Ürünmodel{

                    Ürünismi = "Rayban Gözlük",
                    Tanım = "Yaz Mevsiminde günesin tadını çıkarın",
                    Kategori = new Kategori(){ CategoryId=1,CategoryName = "gözlük" },
                    Marka = "Rayban",
                    Fotograf= new List<Ürünfoto>(){
                        new Ürünfoto{ Id =0,Url="https://cdn.dsmcdn.com//ty140/product/media/images/20210705/11/107190745/159056683/1/1_org.jpg" },
                        new Ürünfoto{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/1200/1800/ty140/product/media/images/20210705/11/107190745/159056683/2/2_org_zoom.jpg" },
                    },
                    Fiyatı= 500,
                    Ürünbilgisi = "Güneş Gözlüğü",
                    Satıcı = "Atasun Optik",
                    ÜrünId = 1,
                    İlkfoto = new Ürünfoto(){Url = "https://cdn.dsmcdn.com//ty140/product/media/images/20210705/11/107190745/159056683/1/1_org.jpg" },
                },
                new Ürünmodel{
                    Ürünismi = "Bershka",
                    Tanım = "Kapitone Çanta",
                    Kategori = new Kategori(){ CategoryId=1,CategoryName = "çanta"},
                    Marka = "Bershka",
                    Fotograf= new List<Ürünfoto>(){
                        new Ürünfoto{ Id =0,Url="https://cdn.dsmcdn.com//ty313/product/media/images/20220131/11/39564033/376265082/1/1_org.jpg" },
                        new Ürünfoto{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/1200/1800/ty314/product/media/images/20220131/11/39564033/376265082/2/2_org_zoom.jpg" },
                    },
                    Fiyatı = 180,
                   Ürünbilgisi = "El Çantası",
                    Satıcı = "Bershka",
                    ÜrünId = 2,
                    İlkfoto = new Ürünfoto(){Url = "https://cdn.dsmcdn.com//ty313/product/media/images/20220131/11/39564033/376265082/1/1_org.jpg" },
                },
                new Ürünmodel{
                     Ürünismi = "Nike Air Jordan",
                    Tanım = "Erkek Spor Ayakkabı",
                    Kategori = new Kategori(){ CategoryId=1,CategoryName = "ayakkabı"},
                    Marka = "Nike",
                    Fotograf = new List<Ürünfoto>(){
                        new Ürünfoto{ Id =0,Url="https://cdn.dsmcdn.com//ty257/product/media/images/20211127/19/176317/323944429/1/1_org.jpg" },
                        new Ürünfoto{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/1200/1800/ty256/product/media/images/20211127/19/176317/323944429/3/3_org_zoom.jpg" },
                    },
                    Fiyatı = 9150,
                    Ürünbilgisi = "Spor Ayakkabı",
                    Satıcı = "Smurf Sport",
                    ÜrünId = 3,
                    İlkfoto = new Ürünfoto(){Url = "https://cdn.dsmcdn.com//ty257/product/media/images/20211127/19/176317/323944429/1/1_org.jpg" },
                },
                new Ürünmodel{
                    Ürünismi = "NEW ERA",
                    Tanım = "New York Yankees ",
                    Kategori = new Kategori(){ CategoryId=1,CategoryName = "şapka"},
                    Marka = "New Era",
                    Fotograf = new List<Ürünfoto>(){
                        new Ürünfoto{ Id =0,Url="https://cdn.dsmcdn.com//ty368/product/media/images/20220320/1/72676248/117692460/1/1_org.jpg" },
                        new Ürünfoto{ Id =1,Url="https://cdn.dsmcdn.com/mnresize/1200/1800/ty366/product/media/images/20220320/1/72676248/117692460/3/3_org_zoom.jpg" },
                    },
                    Fiyatı = 541,
                   Ürünbilgisi = "Şapka",
                    Satıcı = "Chapka",
                    ÜrünId = 4,
                    İlkfoto = new Ürünfoto(){Url = "https://cdn.dsmcdn.com//ty368/product/media/images/20220320/1/72676248/117692460/1/1_org.jpg" },
                },
                new Ürünmodel{
                    Ürünismi= "Calvin Klein",
                    Tanım = "Kol Saati",
                    Kategori = new Kategori(){ CategoryId=1,CategoryName = "saat"},
                    Marka = "Calvin Klein",
                    Fotograf = new List<Ürünfoto>(){
                        new Ürünfoto{ Id =0,Url="https://cdn.dsmcdn.com//ty85/product/media/images/20210402/17/57d80635/11791311/1/1_org.jpg" },
                        new Ürünfoto{ Id =1,Url="https://cdn.dsmcdn.com//ty85/product/media/images/20210402/17/57d80635/11791311/1/1_org.jpg" },
                    },
                    Fiyatı = 2439,
                    Ürünbilgisi = "Kol Saati",
                    Satıcı = "Özlem Saat",
                    ÜrünId = 5,
                    İlkfoto = new Ürünfoto(){Url = "https://cdn.dsmcdn.com//ty85/product/media/images/20210402/17/57d80635/11791311/1/1_org.jpg" },
                },
            };
            }
            return products;

        }
    }
}
