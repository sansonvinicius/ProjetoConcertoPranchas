using ConcertosTelas.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class DeletarPrancha: Comandos
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PranchaViewModel;
            return viewModel != null && viewModel.PranchaSelecionada != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (PranchaViewModel)parameter;
            viewModel.Pranchas.Remove(viewModel.PranchaSelecionada);
            viewModel.PranchaSelecionada = viewModel.Pranchas.FirstOrDefault();
        }
    }
}
