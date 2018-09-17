using ConcertosTelas.ViewsModels;
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
            var viewModel = (ClienteViewModel)parameter;
            var cloneCliente = (ModelConcertos.Cliente)viewModel.ClienteSelecionado.Clone();
            var cw = new TelaAddCliente();
            cw.DataContext = cloneCliente;
            cw.ShowDialog();

            if (cw.DialogResult.HasValue && cw.DialogResult.Value)
            {
                viewModel.ClienteSelecionado.Nome = cloneCliente.Nome;
                viewModel.ClienteSelecionado.Sobrenome = cloneCliente.Sobrenome;
                viewModel.ClienteSelecionado.Email = cloneCliente.Email;
                viewModel.ClienteSelecionado.Cpf = cloneCliente.Cpf;
                viewModel.ClienteSelecionado.Telefone = cloneCliente.Telefone;
                viewModel.ClienteSelecionado.Endereco = cloneCliente.Endereco;


            }
        }
    }
}
