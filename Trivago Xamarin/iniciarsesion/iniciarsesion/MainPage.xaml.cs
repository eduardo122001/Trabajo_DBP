using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn_guardar_Clicked(object sender, EventArgs e)
        {
            string nombre = x_correo.Text;
            string apellido = x_contraseña.Text;


            
            DisplayAlert("Iniciar Sesion", "iniciando sesion ;) ", "Aceptar");


        }

    }
}
