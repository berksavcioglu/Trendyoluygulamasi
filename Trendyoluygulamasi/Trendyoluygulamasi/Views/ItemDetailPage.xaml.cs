using System.ComponentModel;
using Trendyoluygulamasi.ViewModels;
using Xamarin.Forms;

namespace Trendyoluygulamasi.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}