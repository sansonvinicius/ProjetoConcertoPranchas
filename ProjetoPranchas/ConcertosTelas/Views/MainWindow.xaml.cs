using ModelConcertosEntity;
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


        private void ListCliente_Click(object sender, RoutedEventArgs e)
        {
             ListaClientes listaClientes = new ListaClientes();
             listaClientes.Show();

            //ListaCliente lis = new ListaCliente();
            //lis.Show();
        }


        private void ListPrancha_Click(object sender, RoutedEventArgs e)
        {
            ListaPrancha listaPrancha = new ListaPrancha();
            listaPrancha.Show();

        }


        private void ListOS_Click(object sender, RoutedEventArgs e)
        {
            ListaOS listaOS = new ListaOS();
            listaOS.Show();

        }

        private void MenuCliente_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void HistConcetos_Click(object sender, RoutedEventArgs e)
        {
            ConcertosFinalizados concertosFinalizados = new ConcertosFinalizados();
            concertosFinalizados.Show();

        }


        private void AndamentoConcertos_Click(object sender, RoutedEventArgs e)
        {
            ConcertosAndamento concertosAndamento = new ConcertosAndamento();
            concertosAndamento.Show();

        }
    }
}
