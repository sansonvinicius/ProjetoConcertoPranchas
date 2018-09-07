using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas.ViewsModels
{
    class AddOSViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        // o evento abaixo é para executação que não depende do software
        public event PropertyChangedEventHandler PropertyChanged;

        //metodo vai ser chamado pelo conjunto de sets
        private void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }




        #endregion

        #region CamposModelsOS
        private int osID;

        public int OSID
        {
            get { return osID; }

            set
            {
                osID = value;
                NotifyPropertyChanged("OSID");
            }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }

            set
            {
                descricao = value;
                NotifyPropertyChanged("Descricao");
            }
        }

        private string status;

        public string Status
        {
            get { return status; }

            set
            {
                status = value;
                NotifyPropertyChanged("Status");
            }
        }

        private string situacao;

        public string Situacao
        {
            get { return situacao; }

            set
            {
                situacao = value;
                NotifyPropertyChanged("Situacao");
            }
        }

        private int valor;

        public int Valor
        {
            get { return valor; }

            set
            {
                valor = value;
                NotifyPropertyChanged("Valor");
            }
        }

        private DateTime dataEntrada;

        public DateTime DataEntrada
        {
            get { return dataEntrada; }

            set
            {
                dataEntrada = value;
                NotifyPropertyChanged("DataEntrada");
            }
        }

        private DateTime dataSaida;

        public DateTime DataSaida
        {
            get { return dataSaida; }

            set
            {
                dataSaida = value;
                NotifyPropertyChanged("DataSaida");
            }
        }

        #endregion




    }
}

