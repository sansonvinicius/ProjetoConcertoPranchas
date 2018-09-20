
using ModelConcertos;
using ModelConcertosEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
   public class PranchaController
    {
        public ObservableCollection<Prancha> GetPrancha()
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return new ObservableCollection<Prancha>(contexto.PranchaSet.ToList());
        }





    }
}
