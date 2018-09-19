
using ConcertosTelas.Views;
using ModelConcertos;
using ModelConcertosEntity;
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
    class PranchaViewModel : BaseNotifyPropertyChanged

    {

        public AdicionarPrancha AdicionarPrancha { get; private set; } = new AdicionarPrancha();
        public DeletarPrancha DeletarPrancha { get; private set; } = new DeletarPrancha();
        public EditarPrancha EditarPrancha { get; private set; } = new EditarPrancha();

        public ObservableCollection<Prancha> Pranchas { get; set; } = new ObservableCollection<Prancha>();





        private ModelConcertosEntity.Prancha _pranchaSelecionada;
        public ModelConcertosEntity.Prancha PranchaSelecionada
        {
            get { return _pranchaSelecionada; }
            set {
                SetField(ref _pranchaSelecionada, value);
                 DeletarPrancha.RaiseCanExecuteChanged();
                 EditarPrancha.RaiseCanExecuteChanged();

            }

        }

        public PranchaViewModel()
        {
            
            Pranchas= new ObservableCollection<Prancha>();
            Pranchas.Add(new Prancha()
            {
                Id_Prancha = 3,
                Modelo = "LongBoard",
                Marca = "Pro Ilha",
                Medida = "6.5",
                Cor = "Branca",
                QtdQuilhas= 4,
              
            });
            Pranchas.Add(new ModelConcertosEntity.Prancha()
            {
                Id_Prancha = 4,
                Modelo = "Fish",
                Marca = "Canfield",
                Medida = "5.4",
                Cor = "Azul",
                QtdQuilhas = 3,

            });
            PranchaSelecionada = Pranchas.FirstOrDefault();





        }







        }
}

  