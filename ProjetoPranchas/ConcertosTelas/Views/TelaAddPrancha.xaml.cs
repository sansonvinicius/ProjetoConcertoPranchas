using ConcertosTelas.ViewsModels;
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
    /// Lógica interna para TelaAddPrancha.xaml
    /// </summary>
    public partial class TelaAddPrancha : Window
    {
        public TelaAddPrancha()
        {
            InitializeComponent();
         
        }

        private void btnSalvarPrancha_Click(object sender, RoutedEventArgs e)
        {
            AdicionarPrancha cvm = DataContext as AdicionarPrancha;
            DialogResult = true;
        }


        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            TelaAddPrancha Voltar = new TelaAddPrancha();
            this.Close();
        }
    }
}
