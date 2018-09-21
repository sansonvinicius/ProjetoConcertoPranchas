using ConcertosTelas.ViewsModels;
using ControllerConcertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class DeletarCliente: Comandos
    {


       public override bool CanExecute(object parameter)
        {
            var viewModelCliente = parameter as ClienteViewModel;
            return viewModelCliente != null && viewModelCliente.ClienteSelecionado != null;
        }



        public override void Execute(object parameter)
        {
            var viewModelCliente = parameter as ClienteViewModel;
            var cliente = new ModelConcertosEntity.Cliente();
            ClienteController clienteController = new ClienteController();
          
            clienteController.ExcluirCliente(viewModelCliente.ClienteSelecionado.Id_Cliente);
            viewModelCliente.Clientes = clienteController.GetCliente();
        }
    }
}
