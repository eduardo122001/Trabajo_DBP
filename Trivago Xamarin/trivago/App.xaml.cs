﻿using System;
using trivago.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trivago
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new botonView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
