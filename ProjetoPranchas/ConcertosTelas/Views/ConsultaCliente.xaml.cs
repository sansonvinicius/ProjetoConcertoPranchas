using ControllerConcertos;
using ModelConcertos;
using ModelConcertosEntity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace ConcertosTelas.Views
{
    /// <summary>
    /// Lógica interna para ConcertosFinalizados.xaml
    /// </summary>
    public partial class ConsultaCliente : Window
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
        ClienteController clienteController = new ClienteController();

        public ConsultaCliente()
        {
            InitializeComponent();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = clienteController.ClientesOS();
            DataGridConsultaCliente.ItemsSource = query;

        }
    }
}
