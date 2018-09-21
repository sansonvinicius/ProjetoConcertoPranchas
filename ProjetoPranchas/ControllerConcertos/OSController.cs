using ModelConcertosEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
    public class OSController
    {
        public ObservableCollection<OS> GetOS()
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return new ObservableCollection<OS>(contexto.OSSet.ToList());
        }

        public void InserirOs(OS os)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            contexto.OSSet.Add(os);
            contexto.SaveChanges();

        }
        OS BuscarOsPorId(int Id_Os)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return contexto.OSSet.Find(Id_Os);

        }

        public void ExcluirOs(int Id_OS)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

            OS oExcluir = BuscarOsPorId(Id_OS);
            oExcluir = contexto.OSSet.Where(o => o.Id_OS == oExcluir.Id_OS).FirstOrDefault();

            if (oExcluir != null)
            {

                contexto.OSSet.Remove(oExcluir);
                contexto.SaveChanges();


            }
        }

        
    }
}

  