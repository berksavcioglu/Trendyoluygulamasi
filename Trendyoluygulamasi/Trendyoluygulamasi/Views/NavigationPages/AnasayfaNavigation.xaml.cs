using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views.NavigationPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnasayfaNavigation : NavigationPage
    {
        public AnasayfaNavigation(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}