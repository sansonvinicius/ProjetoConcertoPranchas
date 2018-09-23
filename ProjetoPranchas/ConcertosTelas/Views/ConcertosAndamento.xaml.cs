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
    public partial class ConcertosAndamento : Window
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
        OSController oSController = new OSController();

        public ConcertosAndamento()
        {
            InitializeComponent();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = oSController.OSsAndamento();
            DataGridOSAndamento.ItemsSource = query;

        }
    }
}
