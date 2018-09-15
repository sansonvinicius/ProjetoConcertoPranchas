using ConcertosTelas.ViewsModels;
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
            var viewModel = parameter as ClienteViewModel;
            return viewModel != null && viewModel.ClienteSelecionado != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (ClienteViewModel)parameter;
            viewModel.Clientes.Remove(viewModel.ClienteSelecionado);
            viewModel.ClienteSelecionado = viewModel.Clientes.FirstOrDefault();
        }
    }
}
