using ConcertosTelas.ViewsModels;
using ControllerConcertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class EditarCliente : Comandos
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as ClienteViewModel;
            return viewModel != null && viewModel.ClienteSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModelCliente = (ClienteViewModel)parameter;
            var cloneCliente = (ModelConcertosEntity.Cliente)viewModelCliente.ClienteSelecionado.Clone();
            var cw = new TelaAddCliente();
            cw.DataContext = cloneCliente;
            cw.ShowDialog();

            if (cw.DialogResult.HasValue && cw.DialogResult.Value)
            {
                ClienteController clienteController = new ClienteController();
                clienteController.EditarCliente(viewModelCliente.ClienteSelecionado.Id_Cliente, viewModelCliente.ClienteSelecionado);

                viewModelCliente.ClienteSelecionado.Nome = cloneCliente.Nome;
                viewModelCliente.ClienteSelecionado.Sobrenome = cloneCliente.Sobrenome;
                viewModelCliente.ClienteSelecionado.Email = cloneCliente.Email;
                viewModelCliente.ClienteSelecionado.Cpf = cloneCliente.Cpf;
                viewModelCliente.ClienteSelecionado.Telefone = cloneCliente.Telefone;
                viewModelCliente.ClienteSelecionado.Endereco = cloneCliente.Endereco;

                viewModelCliente.Clientes = clienteController.GetCliente();




            }
        }
    }
}
