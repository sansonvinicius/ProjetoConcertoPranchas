﻿using ConcertosTelas.ViewsModels;
using ControllerConcertos;
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

namespace ConcertosTelas
{
    /// <summary>
    /// Lógica interna para AddCliente.xaml
    /// </summary>
    public partial class TelaAddCliente : Window
    {
        public TelaAddCliente()
        {
            InitializeComponent();




        }

        private void btnSalvarCliente_Click(object sender, RoutedEventArgs e)
        {
            AdicionarCliente cvm = DataContext as AdicionarCliente;
            DialogResult = true;

        }




        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            TelaAddCliente Voltar = new TelaAddCliente();
            this.Close();
        }
    }
}

