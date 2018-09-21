
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
        public void InserirPrancha(Prancha prancha)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            contexto.PranchaSet.Add(prancha);
            contexto.SaveChanges();

        }
        Prancha BuscarPranchaPorId(int Id_Prancha)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return contexto.PranchaSet.Find(Id_Prancha);

        }

        public void ExcluirPrancha(int Id_Prancha)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

            Prancha pExcluir = BuscarPranchaPorId(Id_Prancha);
            pExcluir = contexto.PranchaSet.Where(p => p.Id_Prancha == pExcluir.Id_Prancha).FirstOrDefault();

            if (pExcluir != null)
            {

                contexto.PranchaSet.Remove(pExcluir);
                contexto.SaveChanges();


            }
        }


    }
}
