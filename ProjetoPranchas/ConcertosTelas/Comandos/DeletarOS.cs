using ConcertosTelas.ViewsModels;
using ControllerConcertos;
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
            var viewModelOs = parameter as OSViewModel;
            var os = new ModelConcertosEntity.OS();
            OSController osController = new OSController();

            osController.ExcluirOs(viewModelOs.OSSelecionada.Id_OS);
            viewModelOs.OSs = osController.GetOS();

        }
    }
}




