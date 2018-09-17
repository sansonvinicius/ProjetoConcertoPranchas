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
    class ClienteViewModel : BaseNotifyPropertyChanged
    {
        public AdicionarCliente AdicionarCliente { get; private set; } = new AdicionarCliente();
        public DeletarCliente DeletarCliente { get; private set; } = new DeletarCliente();
        public EditarCliente EditarCliente { get; private set; } = new EditarCliente();





        public ObservableCollection<Cliente> Clientes { get; set; }


        private ModelConcertos.Cliente _clienteSelecionado;
        public ModelConcertos.Cliente ClienteSelecionado
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
            Clientes = new System.Collections.ObjectModel.ObservableCollection<ModelConcertos.Cliente>();
            Clientes.Add(new ModelConcertos.Cliente()
            {
                Id_Cliente = 3,
                Nome = "Vinicius",
                Sobrenome = "Sanson",
                Cpf = "072572239-80",
                Email = "sansonvinicius@gmail.com",
                Telefone = "99119-6226",
                Endereco = "Avenida Nossa Senhora da Luz 849",

            });
            Clientes.Add(new ModelConcertos.Cliente()
            {
                Id_Cliente = 4,
                Nome = "Alisson",
                Sobrenome = "Hoffman",
                Cpf = "001001001-01",
                Email = "Alisson@alisson.com.br",
                Telefone = "9999-9999",
                Endereco = "Endereço do Alisson 001",

            });
        }
    }
}
