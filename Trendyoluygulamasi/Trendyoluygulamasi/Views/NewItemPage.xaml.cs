﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Trendyoluygulamasi.Models;
using Trendyoluygulamasi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}