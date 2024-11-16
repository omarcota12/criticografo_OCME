using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calcular_OCME
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCriticarClicked(object sender, EventArgs e)
        {
           
            string nombre = Name.Text?.Trim();

           
          

            
            string genero = null;

            if (Hom.IsChecked)
                genero = "Hombre";
            else if (Muj.IsChecked)
                genero = "Mujer";

           

            
            string caracteristicas = "";
            if (Feo.IsChecked) caracteristicas += "Feo, ";
            if (Alto.IsChecked) caracteristicas += "Alto, ";
            if (Raro.IsChecked) caracteristicas += "Raro, ";
            if (Listo.IsChecked) caracteristicas += "Listo, ";
            if (Extravagante.IsChecked) caracteristicas += "Extravagante, ";

            if (string.IsNullOrWhiteSpace(caracteristicas))
                caracteristicas = "sin características seleccionadas";
            else
                caracteristicas = caracteristicas.TrimEnd(',', ' ');

            
            ShowMessage("Resultado", $"{nombre}, es {genero} y es: {caracteristicas}.");
        }

        private void ShowMessage(string title, string message)
        {
           
            Application.Current.MainPage.DisplayAlert(title, message, "OK").ConfigureAwait(false);
        }
    }
}
