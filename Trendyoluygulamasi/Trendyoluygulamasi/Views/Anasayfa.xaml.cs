
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public ICommand ScrollListCommand { get; set; }
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }
    }
}