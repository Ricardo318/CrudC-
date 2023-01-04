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

namespace Examen1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e) 
        {
            AgregarEquipo agregar = new AgregarEquipo();
            agregar.ShowDialog();
        }
                        
        private void ListarTodos_Click(object sender, RoutedEventArgs e) 
        {
            ListarEquipos listar = new ListarEquipos();
            listar.ShowDialog(); 
        }

        private void Acerca_de_Click(object sender, RoutedEventArgs e) 
        {
           Acerca_de acerca = new Acerca_de();
            acerca.ShowDialog();
        }
    }
}
