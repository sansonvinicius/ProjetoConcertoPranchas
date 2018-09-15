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
using System.Windows.Shapes;

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
    }
}

