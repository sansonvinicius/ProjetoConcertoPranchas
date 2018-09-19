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
    class OSViewModel : BaseNotifyPropertyChanged
    {
        public AdicionarOS AdicionarOS { get; private set; } = new AdicionarOS();
        public DeletarOS DeletarOS { get; private set; } = new DeletarOS();
        public EditarOS EditarOS { get; private set; } = new EditarOS();




        public ObservableCollection<OS> OSs { get; set; }


        private ModelConcertosEntity.OS _osSelecionada;
        public ModelConcertosEntity.OS OSSelecionada
        {
            get { return _osSelecionada; }
            set {
                SetField(ref _osSelecionada, value);
                DeletarOS.RaiseCanExecuteChanged();
                EditarOS.RaiseCanExecuteChanged();


            }
        }
        public OSViewModel()
        {
            OSs = new System.Collections.ObjectModel.ObservableCollection<ModelConcertosEntity.OS>();
        }
    }

}


