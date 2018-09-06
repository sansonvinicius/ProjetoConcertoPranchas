using ConcertosTelas.Views;
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

namespace ConcertosTelas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void AdicCliente_Click(object sender, RoutedEventArgs e)
        {
            TelaAddCliente telaAddCliente = new TelaAddCliente();
            telaAddCliente.Show();
        }

        private void AdicPrancha_Click(object sender, RoutedEventArgs e)
        {
            TelaAddPrancha telaAddPrancha = new TelaAddPrancha();
            telaAddPrancha.Show();
        }

        private void AdicOrdem_Click(object sender, RoutedEventArgs e)
        {
            TelaAddOS telaAddPrancha = new TelaAddOS();
            telaAddPrancha.Show();

        }

        private void ListCliente_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
        }

    }
}
