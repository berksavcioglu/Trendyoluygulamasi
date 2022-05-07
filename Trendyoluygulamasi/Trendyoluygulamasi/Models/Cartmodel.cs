using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyoluygulamasi.Models
{
    public class Cartmodel
    {
        public Cartmodel()
        {
            Count = 1;
        }
        public Ürünmodel Product { get; set; }
        public int Count { get; set; }
    }
}
