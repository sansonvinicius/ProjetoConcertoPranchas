using ConcertosTelas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas.ViewsModels
{
    class ListaOSViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        // para usar a lista de clientes
        public ObservableCollection<OS> OSs { get; set; }

        public ListaOSViewModel()
        {
            OSs = new ObservableCollection<OS>();
            OSs.Add(
                new OS()
                {
                    Descricao = "",
                    Situacao = "",
                    Status = "",
                    Valor = "",
                    DataEntrada = "",
                    DataSaida = "",
                }
                );
        }
    }
}


