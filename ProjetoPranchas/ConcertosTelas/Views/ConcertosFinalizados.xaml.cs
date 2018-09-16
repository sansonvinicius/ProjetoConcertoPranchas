using ModelConcertos;
using ModelConcertosEntity;
using System.Windows;

namespace ConcertosTelas.Views
{
    /// <summary>
    /// Lógica interna para ConcertosFinalizados.xaml
    /// </summary>
    public partial class ConcertosFinalizados : Window
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

        public ConcertosFinalizados()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            //DataGridOS.ItemsSource = List<OS>PesquisarPorStatus(string Status).toList();

        }
    }
}
