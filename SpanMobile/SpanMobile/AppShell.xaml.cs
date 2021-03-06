﻿using SpanMobile.ViewModels;
using SpanMobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SpanMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Adder), typeof(Adder));
            Routing.RegisterRoute(nameof(Calculator), typeof(Calculator));
            Routing.RegisterRoute(nameof(ToDoApp), typeof(ToDoApp));
        }

    }
}
