
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
    class PranchaController
    {
      public  List<Prancha> ListarPranchas()
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return contexto.PranchaSet.ToList();
        }
    





    }
}
