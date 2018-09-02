using ModelConcertos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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

namespace ConcertosTelas.Views
{
    /// <summary>
    /// Lógica interna para ListaClientes.xaml
    /// </summary>
    public partial class ListaClientes : Window
    {
        ModelConcertosContainer contexto = new ModelConcertosContainer();

        public ListaClientes()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            List<Cliente> ListarTodosClientes()
            {

                return contexto.ClienteSet.ToList();
            }

            DataGridClientes.ItemsSource = ListarTodosClientes().ToList();
        }
    }
}

