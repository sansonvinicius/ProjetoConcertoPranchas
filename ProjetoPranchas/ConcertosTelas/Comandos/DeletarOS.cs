using ConcertosTelas.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class DeletarOS : Comandos
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as OSViewModel;
            return viewModel != null && viewModel.OSSelecionada != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (OSViewModel)parameter;
            viewModel.OSs.Remove(viewModel.OSSelecionada);
            viewModel.OSSelecionada = viewModel.OSs.FirstOrDefault();
        }
    }
}
