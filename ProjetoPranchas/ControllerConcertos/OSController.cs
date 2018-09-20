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
    }
}
