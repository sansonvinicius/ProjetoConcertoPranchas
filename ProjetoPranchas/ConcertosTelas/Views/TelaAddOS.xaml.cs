using ConcertosTelas.ViewsModels;
using ControllerConcertos;
using System.Windows;

namespace ConcertosTelas.Views
{
    /// <summary>
    /// Lógica interna para TelaAddOS.xaml
    /// </summary>
    public partial class TelaAddOS : Window
    {
     

        public TelaAddOS()
        {
            
            InitializeComponent();

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

        private void ConsultaClientes_Click(object sender, RoutedEventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.Show();
        }

        private void ConsultaPranchas_Click(object sender, RoutedEventArgs e)
        {
            ConsultaPrancha consultaPrancha = new ConsultaPrancha();
            consultaPrancha.Show();
        }

    }
}




