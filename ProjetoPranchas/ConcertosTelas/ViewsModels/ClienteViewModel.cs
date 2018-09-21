using ControllerConcertos;
using ModelConcertosEntity;
using System.Collections.ObjectModel;

namespace ConcertosTelas.ViewsModels
{
    class ClienteViewModel :  BaseNotifyPropertyChanged 

    {
        public AdicionarCliente AdicionarCliente { get; private set; } = new AdicionarCliente();
        public DeletarCliente DeletarCliente { get; private set; } = new DeletarCliente();
        public EditarCliente EditarCliente { get; private set; } = new EditarCliente();

        private ObservableCollection<Cliente> _clientes;
        public ObservableCollection<Cliente> Clientes
        {
            get { return _clientes; }
            set
            {
                SetField(ref _clientes, value);

            }
        }

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
            ClienteController clienteController = new ClienteController();
            Clientes = clienteController.GetCliente();
         
        }
    }
}
