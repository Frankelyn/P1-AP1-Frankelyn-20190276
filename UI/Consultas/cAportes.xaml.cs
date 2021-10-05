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

namespace P1_AP1_Frankelyn_20190276.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cAportes.xaml
    /// </summary>
    public partial class cAportes : Window
    {
        public cAportes()
        {
            InitializeComponent();
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (CriterioTextbox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            listado = AportesBLL.GetList(e => e.Persona.Contains(CriterioTextbox.Text));
                            break;
                        }
                    case 1:
                        {
                            listado = AportesBLL.GetList(e => e.Concepto.Contains(CriterioTextbox.Text));
                            break;
                        }
                            
                }
            }
            else
            {
                listado = AportesBLL.GetList(e => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
                listado = AportesBLL.GetList(e => e.Fecha.Date >= DesdeDatePicker.SelectedDate);

            if (HastaDatePicker.SelectedDate != null)
                listado = AportesBLL.GetList(e => e.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            var monto = listado.Sum(x => x.Monto);

            string valor;

            valor = Convert.ToString(monto);

            TotalTextBox.Text = valor;
            TotalTextBox.IsEnabled = false;

            var conteo = listado.Count;

            valor = Convert.ToString(conteo);

            ConteoTextBox.Text = valor;
            ConteoTextBox.IsEnabled = false;
        }
            
    }
}
