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
    public partial class ConsultaPrancha : Window
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
        PranchaController pranchaController = new PranchaController();

        public ConsultaPrancha()
        {
            InitializeComponent();

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = pranchaController.PranchasOS();
            DataGridConsultaPrancha.ItemsSource = query;

        }
    }
}
