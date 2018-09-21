using ModelConcertosEntity;
using ConcertosTelas.Views;
using ConcertosTelas.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerConcertos;

namespace ConcertosTelas
{
    class AdicionarCliente : Comandos
    {


        public override bool CanExecute(object parameter)
        {
            return parameter is ClienteViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModelCliente = (ClienteViewModel)parameter;
            var cliente = new ModelConcertosEntity.Cliente();
         

            var cw = new TelaAddCliente();
            cw.DataContext = cliente;
            cw.ShowDialog();

            if (cw.DialogResult.HasValue && cw.DialogResult.Value)
            {//Controller
                ClienteController clienteController = new ClienteController();
                clienteController.InserirCliente(cliente);
                viewModelCliente.Clientes = clienteController.GetCliente();
           
               


            }
        }


    }
}

