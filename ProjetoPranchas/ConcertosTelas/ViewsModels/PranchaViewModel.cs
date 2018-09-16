
using ConcertosTelas.Views;
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
            
            Pranchas = new System.Collections.ObjectModel.ObservableCollection<ModelConcertosEntity.Prancha>();
            Pranchas.Add(new ModelConcertosEntity.Prancha()
            {
                Id_Prancha = 3,
                Modelo = "Teste",
                Marca = "Teste",
                Medida = "Teste",
                Cor = "Cor",
                QtdQuilhas= "4"
            });
            PranchaSelecionada = Pranchas.FirstOrDefault();




        }









    }
}

  