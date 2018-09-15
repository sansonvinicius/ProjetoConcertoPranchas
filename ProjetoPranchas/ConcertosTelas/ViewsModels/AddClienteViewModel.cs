using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConcertosTelas.ViewsModels
{
    public class AddClienteViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        // o evento abaixo é para executação que não depende do software
        public event PropertyChangedEventHandler PropertyChanged;

        //metodo vai ser chamado pelo conjunto de sets
        private void NotifyPropertyChanged([CallerMemberName]string propertyName ="")
        {
            if (PropertyChanged !=null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
        


        #region CamposModelsCliente
        private int clienteID;

        public int ClienteID
        {
            get { return clienteID;  }

            set
            {
                clienteID = value;
                NotifyPropertyChanged("ClienteID");
            }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }

            set
            {
                nome = value;
                NotifyPropertyChanged("Nome");
            }
        }

        private string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }

            set
            {
                sobrenome = value;
                NotifyPropertyChanged("Sobrenome");
            }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }

            set
            {
                cpf = value;
                NotifyPropertyChanged("Cpf");
            }
        }

        private string email;

        public string Email
        {
            get { return email; }

            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }

            set
            {
                endereco = value;
                NotifyPropertyChanged("Endereco");
            }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }

            set
            {
                telefone = value;
                NotifyPropertyChanged("Telefone");
            }
        }

        #endregion




    }
}
