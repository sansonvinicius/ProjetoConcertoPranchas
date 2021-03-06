﻿using ControllerConcertos;
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

        private ObservableCollection<OS> _oss;
        public ObservableCollection<OS> OSs
        {
            get { return _oss; }
            set
            {
                SetField(ref _oss, value);

            }
        }

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
            OSController osController = new OSController();
            OSs = osController.GetOS();
         


        }
    }

}


