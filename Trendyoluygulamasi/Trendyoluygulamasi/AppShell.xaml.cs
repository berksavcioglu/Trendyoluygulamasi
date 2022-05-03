using System;
using System.Collections.Generic;
using Trendyoluygulamasi.ViewModels;
using Trendyoluygulamasi.Views;
using Xamarin.Forms;

namespace Trendyoluygulamasi
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
