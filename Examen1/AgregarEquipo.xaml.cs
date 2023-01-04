using System;

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

namespace Examen1
{
    /// <summary>
    /// Lógica de interacción para AgregarEquipo.xaml
    /// </summary>
    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void btn_Enviar_Click(object sender, RoutedEventArgs e)
        {
            string NombreEquipo = txtNombre.Text;
            int Cantidad = Convert.ToInt32(txtCantidad);
            string Nombredt = txtNombredt.Text;
            string TipoEquipo = txtTipoEquipo.Text;
            string Capitan = txtCapitan.Text;
            bool TieneSub21 = (Chksi.IsChecked.Value) ? true : false;


            Clases.Equipo equipo = new(NombreEquipo, Cantidad, Nombredt, TipoEquipo, Capitan, TieneSub21);
           
           
        }
    }     
}
