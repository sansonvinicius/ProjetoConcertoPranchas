using ConcertosTelas.Views;
using ModelConcertos;
using ModelConcertosEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
    class ConcertosController
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

        List<OS> PesquisarPorStatus(string Status)
        { 

            var lista = from os in contexto.OSSet
                        where os.Status == "Finalizado"
                        select os;

            return lista.ToList();

        }
    }
}
