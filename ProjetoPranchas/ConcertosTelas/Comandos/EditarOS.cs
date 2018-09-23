using ConcertosTelas.Views;
using ConcertosTelas.ViewsModels;
using ControllerConcertos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class EditarOS : Comandos
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as OSViewModel;
            return viewModel != null && viewModel.OSSelecionada != null;
        }

        public override void Execute(object parameter)
        {
            var viewModelOS = (OSViewModel)parameter;
            var cloneOS = (ModelConcertosEntity.OS)viewModelOS.OSSelecionada.Clone();
            var cw = new TelaAddOS();
            cw.DataContext = cloneOS;
            cw.ShowDialog();

            if (cw.DialogResult.HasValue && cw.DialogResult.Value)
            {

                OSController osController = new OSController();

                viewModelOS.OSSelecionada.Descricao = cloneOS.Descricao;
                viewModelOS.OSSelecionada.Valor = cloneOS.Valor;
                viewModelOS.OSSelecionada.Data_Entrada = cloneOS.Data_Entrada;
                viewModelOS.OSSelecionada.Data_Saida = cloneOS.Data_Saida;
                viewModelOS.OSSelecionada.Status = cloneOS.Status;
                viewModelOS.OSSelecionada.Situacao = cloneOS.Situacao;
                viewModelOS.OSSelecionada.ClienteId_Cliente = cloneOS.ClienteId_Cliente;
                viewModelOS.OSSelecionada.PranchaId_Prancha = cloneOS.PranchaId_Prancha;

                osController.EditarOS(viewModelOS.OSSelecionada.Id_OS, viewModelOS.OSSelecionada);

                viewModelOS.OSs = osController.GetOS();


            }


        }
    }
}
