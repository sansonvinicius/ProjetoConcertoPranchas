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
    class AdicionarOS : Comandos
    {


        public override bool CanExecute(object parameter)
        {
            return parameter is OSViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModelOS = (OSViewModel)parameter;
            var os = new ModelConcertos.OS();
            var maxId = 0;

            if (viewModelOS.OSs.Any())
            {
               maxId = viewModelOS.OSs.Max(o => o.Id_OS);
            }
            os.Id_OS = maxId + 1;

            var ow = new TelaAddOS();
            ow.DataContext = os;
            ow.ShowDialog();
            
            if (ow.DialogResult.HasValue && ow.DialogResult.Value)
            {
                viewModelOS.OSs.Add(os);
                viewModelOS.OSSelecionada = os;
                
            }
        }
      

    }
}

