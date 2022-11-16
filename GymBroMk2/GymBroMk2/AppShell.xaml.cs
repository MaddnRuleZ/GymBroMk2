using GymBroMk2.ViewModels;
using GymBroMk2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GymBroMk2
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
