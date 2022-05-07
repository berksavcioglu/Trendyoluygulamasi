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
    public partial class ÜrünNavigation : NavigationPage
    {
        public ÜrünNavigation(Page page) : base(page)
        {
            InitializeComponent();
        }
    }
}