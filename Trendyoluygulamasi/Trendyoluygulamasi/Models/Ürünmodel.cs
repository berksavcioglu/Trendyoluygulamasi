using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyoluygulamasi.Models
{
    public class Ürünmodel
    {
        public Ürünmodel()
        {
            DeliveryDate = DateTime.Now;
            
        }
        public int ÜrünId { get; set; }
        public string Marka { get; set; }
        public string Ürünismi { get; set; }
        public string Tanım { get; set; }
        public List<Ürünfoto> Fotograf { get; set; }
        public Ürünfoto İlkfoto { get; set; }

        public string Satıcı { get; set; }
        public string Ürünbilgisi { get; set; }
        public List<Yorummodel> Comments { get; set; }
        public decimal Fiyatı { get; set; }
        public Kategori Kategori{ get; set; }
       
        public DateTime DeliveryDate { get; set; }
        

    }
}
