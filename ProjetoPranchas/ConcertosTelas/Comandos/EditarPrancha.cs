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
    class EditarPrancha : Comandos
    {
        public override bool CanExecute(object parameter)
        {
            var viewModel = parameter as PranchaViewModel;
            return viewModel != null && viewModel.PranchaSelecionada != null;
        }

        public override void Execute(object parameter)
        {
            var viewModelPrancha = (PranchaViewModel)parameter;
            var clonePrancha = (ModelConcertosEntity.Prancha)viewModelPrancha.PranchaSelecionada.Clone();
            var fw = new TelaAddPrancha();
            fw.DataContext = clonePrancha;
            fw.ShowDialog();

            if (fw.DialogResult.HasValue && fw.DialogResult.Value)
            {
                PranchaController pranchaController = new PranchaController();

                viewModelPrancha.PranchaSelecionada.Modelo = clonePrancha.Modelo;
                viewModelPrancha.PranchaSelecionada.Marca = clonePrancha.Marca;
                viewModelPrancha.PranchaSelecionada.Medida = clonePrancha.Medida;
                viewModelPrancha.PranchaSelecionada.Cor = clonePrancha.Cor;
                viewModelPrancha.PranchaSelecionada.QtdQuilhas = clonePrancha.QtdQuilhas;

                pranchaController.EditarPrancha(viewModelPrancha.PranchaSelecionada.Id_Prancha, viewModelPrancha.PranchaSelecionada);


            }
        }
    }
}
