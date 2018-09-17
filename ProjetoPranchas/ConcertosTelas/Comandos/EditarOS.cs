using ConcertosTelas.Views;
using ConcertosTelas.ViewsModels;
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
            var viewModel = (OSViewModel)parameter;
            var cloneOS = (ModelConcertos.OS)viewModel.OSSelecionada.Clone();
            var cw = new TelaAddOS();
            cw.DataContext = cloneOS;
            cw.ShowDialog();

            if (cw.DialogResult.HasValue && cw.DialogResult.Value)
            {
                viewModel.OSSelecionada.Descricao = cloneOS.Descricao;
                viewModel.OSSelecionada.Valor = cloneOS.Valor;
                viewModel.OSSelecionada.Data_Entrada = cloneOS.Data_Entrada;
                viewModel.OSSelecionada.Data_Saida = cloneOS.Data_Saida;
                viewModel.OSSelecionada.Status = cloneOS.Status;
                viewModel.OSSelecionada.Situacao = cloneOS.Situacao;
                viewModel.OSSelecionada.Cliente = cloneOS.Cliente;


            }


        }
    }
}
