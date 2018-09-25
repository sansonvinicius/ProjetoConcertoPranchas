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
    class AdicionarOS : Comandos
    {
        
        public override bool CanExecute(object parameter)
        {
            return parameter is OSViewModel;
        }
        public override void Execute(object parameter)
        {
            var viewModelOS = (OSViewModel)parameter;
            var os = new ModelConcertosEntity.OS();
            var c = new ModelConcertosEntity.Cliente();
      
            var ow = new TelaAddOS();
            ow.DataContext = os;
            ow.ShowDialog();
            
            if (ow.DialogResult.HasValue && ow.DialogResult.Value)
            {
                OSController osController = new OSController();
                osController.InserirOs(os);
                if(os.PranchaId_Prancha == 0)
                {
                    TelaAddOS telaAddOS = new TelaAddOS();
                    telaAddOS.btnSalvarOS.DataContext = null;
                }
                if (os.ClienteId_Cliente == 0)
                {
                    TelaAddOS telaAddOS = new TelaAddOS();
                    telaAddOS.btnSalvarOS.DataContext = null;
                }

                viewModelOS.OSs = osController.GetOS();

                               
            }


        }

      
    }
}
