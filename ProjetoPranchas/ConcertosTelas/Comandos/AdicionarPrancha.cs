using ModelConcertosEntity;
using ConcertosTelas.Views;
using ConcertosTelas.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas
{
    class AdicionarPrancha : Comandos
    {


        public override bool CanExecute(object parameter)
        {
            return parameter is PranchaViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModelPrancha = (PranchaViewModel)parameter;
            var prancha = new ModelConcertos.Prancha();
            var maxId = 0;
                    if (viewModelPrancha.Pranchas.Any())
            {
               maxId = viewModelPrancha.Pranchas.Max(p => p.Id_Prancha);
            }
            prancha.Id_Prancha = maxId + 1;

            var pw = new TelaAddPrancha();
            pw.DataContext = prancha;
            pw.ShowDialog();
            
            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                viewModelPrancha.Pranchas.Add(prancha);
                viewModelPrancha.PranchaSelecionada = prancha;
                
            }
        }
      

    }
}

