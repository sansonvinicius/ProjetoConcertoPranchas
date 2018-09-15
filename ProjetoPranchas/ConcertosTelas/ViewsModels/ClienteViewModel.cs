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
    class ClienteViewModel : BaseNotifyPropertyChanged
    {
        public AdicionarCliente AdicionarCliente { get; private set; } = new AdicionarCliente();
        public DeletarCliente DeletarCliente { get; private set; } = new DeletarCliente();
        public EditarCliente EditarCliente { get; private set; } = new EditarCliente();





        public ObservableCollection<Cliente> Clientes { get; set; }


        private ModelConcertosEntity.Cliente _clienteSelecionado;
        public ModelConcertosEntity.Cliente ClienteSelecionado
        {
            get { return _clienteSelecionado; }
            set {
                SetField(ref _clienteSelecionado, value);
                DeletarCliente.RaiseCanExecuteChanged();
                EditarCliente.RaiseCanExecuteChanged();


            }
        }
        public ClienteViewModel()
        {
            Clientes = new System.Collections.ObjectModel.ObservableCollection<ModelConcertosEntity.Cliente>();
        }
    }
}
