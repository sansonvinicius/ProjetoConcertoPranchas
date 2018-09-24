using ConcertosTelas.ViewsModels;
using ControllerConcertos;
using ModelConcertosEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica interna para TelaAddOS.xaml
    /// </summary>
    public partial class TelaAddOS : Window
    {
        ClienteController clienteController = new ClienteController();
        PranchaController pranchaController = new PranchaController();

        public TelaAddOS()
        {
            
            InitializeComponent();
            clienteController.ClientesOS();
            pranchaController.PranchasOS();


        }

        public void ComboBoxCliente_Loaded(object sender, RoutedEventArgs e)
        {
            ClienteController clienteController = new ClienteController();
            var queryCliente = clienteController.ClientesOS();
            ComboBoxCliente.ItemsSource = queryCliente;
            DataContext = queryCliente;

        }

        private void ComboBoxPrancha_Loaded(object sender, RoutedEventArgs e)
        {
            PranchaController pranchaController = new PranchaController();
            var queryPrancha = pranchaController.PranchasOS();
            ComboBoxPrancha.ItemsSource = queryPrancha;
            DataContext = queryPrancha;


        }



        private void btnSalvarOS_Click(object sender, RoutedEventArgs e)
        {
         
            AdicionarOS cvm = DataContext as AdicionarOS;
            DialogResult = true;
        }
        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            TelaAddOS Voltar = new TelaAddOS();
            this.Close();
        }

        private void ComboBoxCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ComboBoxCliente.SelectedItem as ClienteDTO;
        }
    }


}

