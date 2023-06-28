using System;
using Trivago.Vista;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trivago
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GuardarHotel();
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
