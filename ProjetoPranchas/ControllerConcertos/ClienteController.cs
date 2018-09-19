using ModelConcertos;
using ModelConcertosEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
    public class ClienteController 
    {
        public void InserirCliente(Cliente cliente)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            contexto.ClienteSet.Add(cliente);
            contexto.SaveChanges();


        }

       public List<Cliente> ListarTodosClientes()
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return contexto.ClienteSet.ToList();
        }

        public ObservableCollection<Cliente> GetCliente()
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return new ObservableCollection<Cliente>(contexto.ClienteSet.ToList());
        }

        Cliente BuscarClientePorId(int Id_Cliente)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            return contexto.ClienteSet.Find(Id_Cliente);

        }

        void ExcluirCliente(int Id_Cliente)
        {
            Cliente cExcluir = BuscarClientePorId(Id_Cliente);

            if (cExcluir != null)
            {
                ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
                contexto.ClienteSet.Remove(cExcluir);
                contexto.SaveChanges();


            }
        }

        void EditarCliente(int Id_Cliente, Cliente novosDadosCliente)
        {
            //Procura por id e atualiza os dados em novoDadosPerson
            Cliente clienteAntigo = BuscarClientePorId(Id_Cliente);

            if (clienteAntigo != null)
            {
                clienteAntigo.Nome= novosDadosCliente.Nome;
                clienteAntigo.Sobrenome = novosDadosCliente.Sobrenome;
                clienteAntigo.Cpf = novosDadosCliente.Cpf;
                clienteAntigo.Telefone = novosDadosCliente.Telefone;
                clienteAntigo.Email = novosDadosCliente.Email;
                clienteAntigo.Endereco = novosDadosCliente.Endereco;


                ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
                contexto.Entry(clienteAntigo).State = System.Data.Entity.EntityState.Modified;

                contexto.SaveChanges();
            }
        }
    }
}
