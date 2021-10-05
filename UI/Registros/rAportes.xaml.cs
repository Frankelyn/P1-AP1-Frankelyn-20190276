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
using System.Windows.Shapes;
using P1_AP1_Frankelyn_20190276.Entidades;
using P1_AP1_Frankelyn_20190276.BLL;

namespace P1_AP1_Frankelyn_20190276.UI.Registros
{
    /// <summary>
    /// Interaction logic for rAportes.xaml
    /// </summary>
    public partial class rAportes : Window
    {
        public rAportes()
        {
            InitializeComponent();
            this.DataContext = aporte;
        }

        public int Toint (string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);
            return retorno;
        }

        private Aportes aporte = new Aportes();

        private void Limpiar()
        {
            this.aporte = new Aportes();
            this.DataContext = aporte;

        }

        private bool validar()
        {
            bool esValido = true;

            if (PersonaTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Debe agregar la Persona", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if(ConceptoTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Debe Agregar el Concepto", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (MontoTextbox.Text == "0")
            {
                esValido = false;
                MessageBox.Show("Debe Agregar el Monto", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            return esValido;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var aporte = AportesBLL.Buscar(Toint(AporteIdTextbox.Text));

            if (aporte == null)
            {
                MessageBox.Show("Registro no encontrado!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (aporte != null)
                this.aporte = aporte;
            else
                this.aporte = new Aportes();

            this.DataContext = this.aporte;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!validar())
                return;

            var paso = AportesBLL.Guardar(aporte);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Trasaccion exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Trasaccion fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (AportesBLL.Eliminar(Toint(AporteIdTextbox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
