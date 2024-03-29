﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SifremiUnuttum());
        }
        private void Register(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new KayitOl());
        }
    }
}