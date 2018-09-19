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
            var maxId = 0;
            if (viewModelCliente.Clientes.Any())
            {
                maxId = viewModelCliente.Clientes.Max(p => p.Id_Cliente);
            }
            cliente.Id_Cliente = maxId + 1;

            var cw = new TelaAddCliente();
            cw.DataContext = cliente;
            cw.ShowDialog();

            if (cw.DialogResult.HasValue && cw.DialogResult.Value)
            {//Controller
                ClienteController clienteController = new ClienteController();
               // viewModelCliente.Clientes = clienteController.InserirCliente(cliente);
                
                //viewModelCliente.Clientes.Add(cliente);
                viewModelCliente.ClienteSelecionado = cliente;

            }
        }


    }
}

