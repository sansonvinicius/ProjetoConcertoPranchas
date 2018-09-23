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
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

        public ObservableCollection<OS> GetOS()
        {
            return new ObservableCollection<OS>(contexto.OSSet.ToList());
        }

        public void InserirOs(OS os)
        {
            contexto.OSSet.Add(os);
            contexto.SaveChanges();

        }
        OS BuscarOsPorId(int Id_Os)
        {
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


        public List<OS> OSsFinalizadas()
        {

            //LINQ
            //var lista = from p in contexto.Person
            // select p;
            //esse é o select * from person

            var listaFinalizadas = from os in contexto.OSSet
                                where os.Status =="Finalizado"
                                   select os;
            return listaFinalizadas.ToList();
          
        }




    }
}

  