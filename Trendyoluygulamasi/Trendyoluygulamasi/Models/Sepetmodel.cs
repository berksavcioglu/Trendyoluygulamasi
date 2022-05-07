using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyoluygulamasi.Models
{
    public class Sepetmodel
    {
        public Sepetmodel()
        {
            Count = 1;
        }
        public Ürünmodel Product { get; set; }
        public int Count { get; set; }
    }
}
