using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas.ViewsModels
{
    class AddPranchaViewModel : INotifyPropertyChanged
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

        #region CamposModelsPrancha
        private int pranchaID;

        public int PranchaID
        {
            get { return pranchaID; }

            set
            {
                pranchaID = value;
                NotifyPropertyChanged("PranchaID");
            }
        }

        private string marca;

        public string Marca
        {
            get { return marca; }

            set
            {
                marca = value;
                NotifyPropertyChanged("Marca");
            }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }

            set
            {
                modelo = value;
                NotifyPropertyChanged("Modelo");
            }
        }

        private string medida;

        public string Medida
        {
            get { return medida; }

            set
            {
                medida = value;
                NotifyPropertyChanged("Medida");
            }
        }

        private string cor;

        public string Cor
        {
            get { return cor; }

            set
            {
                cor = value;
                NotifyPropertyChanged("Cor");
            }
        }

        private int qdtQuilhas;

        public int QtdQuilhas
        {
            get { return qdtQuilhas; }

            set
            {
                qdtQuilhas = value;
                NotifyPropertyChanged("QtdQuilhas");
            }
        }

        
        #endregion




    }
}

    

    

