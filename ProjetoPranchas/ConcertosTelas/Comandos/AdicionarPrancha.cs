using ModelConcertosEntity;
using ConcertosTelas.Views;
using ConcertosTelas.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerConcertos;

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
            var prancha = new ModelConcertosEntity.Prancha();
            
            var pw = new TelaAddPrancha();
            pw.DataContext = prancha;
            pw.ShowDialog();
            
            if (pw.DialogResult.HasValue && pw.DialogResult.Value)
            {
                PranchaController pranchaController = new PranchaController();
                pranchaController.InserirPrancha(prancha);
                viewModelPrancha.Pranchas = pranchaController.GetPrancha();

         
                
            }
        }
      

    }
}

