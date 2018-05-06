using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Solucion.Negocio;

namespace Solucion.Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValida_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string dv = txtDigitoVerificador.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.SelectedDate.Value;
                long rut = long.Parse(txtRut.Text);

                Persona p = new Persona(nombre,rut,dv,fechaNacimiento);

                MessageBox.Show("Se ha instanciado la persona");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
