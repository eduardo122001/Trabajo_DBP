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
            string nombre = x_nombre.Text;
            string apellido = x_apellido.Text;
            string correo = x_correo.Text;
            string contraseña = x_contraseña.Text;

            // Aquí puedes realizar las operaciones que desees con los datos ingresados

            // Por ejemplo, mostrar un mensaje de confirmación
            DisplayAlert("Guardado", "Los datos se han guardado correctamente", "Aceptar");
            
            
        }
       
    }
}
