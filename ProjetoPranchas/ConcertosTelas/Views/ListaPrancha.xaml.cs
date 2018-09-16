using ConcertosTelas.ViewsModels;
using ModelConcertos;
using ModelConcertosEntity;
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
    /// Lógica interna para ListaPrancha.xaml
    /// </summary>
    public partial class ListaPrancha : Window
    {
        public ListaPrancha()
        {
            InitializeComponent();
            DataContext = new PranchaViewModel();
            
        }
       
    }
}
