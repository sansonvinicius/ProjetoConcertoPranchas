
using ConcertosTelas.Views;
using ControllerConcertos;
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

            PranchaController pranchaController = new PranchaController();
            Pranchas = pranchaController.GetPrancha();





        }







        }
}

  