using ConcertosTelas.Views;
using ConcertosTelas.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class EditarPrancha : Comandos
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PranchaViewModel;
            return viewModel != null && viewModel.PranchaSelecionada != null;
        }

        public override void Execute(object parameter)
        {
            var viewModel = (PranchaViewModel)parameter;
            var clonePrancha = (ModelConcertosEntity.Prancha)viewModel.PranchaSelecionada.Clone();
            var fw = new TelaAddPrancha();
            fw.DataContext = clonePrancha;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                viewModel.PranchaSelecionada.Modelo = clonePrancha.Modelo;
                viewModel.PranchaSelecionada.Marca = clonePrancha.Marca;
                viewModel.PranchaSelecionada.Medida = clonePrancha.Medida;
                viewModel.PranchaSelecionada.Cor = clonePrancha.Cor;
                viewModel.PranchaSelecionada.QtdQuilhas = clonePrancha.QtdQuilhas;

            }
        }
    }
}
