using ModelConcertos;
using ModelConcertosEntity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerConcertos
{
    public class ClienteController 
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();


        public void InserirCliente(Cliente cliente)
        {
            contexto.ClienteSet.Add(cliente);
            contexto.SaveChanges();

        }


        public ObservableCollection<Cliente> GetCliente()
        {
            return new ObservableCollection<Cliente>(contexto.ClienteSet.ToList());
        }



        Cliente BuscarClientePorId(int Id_Cliente)
        {
            return contexto.ClienteSet.Find(Id_Cliente);

        }

        public void ExcluirCliente(int Id_Cliente)
        {

            Cliente cExcluir = BuscarClientePorId(Id_Cliente);
            cExcluir = contexto.ClienteSet.Where(c => c.Id_Cliente == cExcluir.Id_Cliente).FirstOrDefault();

            if (cExcluir != null)
            {

                contexto.ClienteSet.Remove(cExcluir);
                contexto.SaveChanges();


            }
        }

        public void EditarCliente(int Id_Cliente, Cliente novosDadosCliente)
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
               
                contexto.Entry(clienteAntigo).State = System.Data.Entity.EntityState.Modified;
               

                contexto.SaveChanges();

            }
        }

        public List<ClienteDTO> ClientesOS()
        {



            var ListaClientesOS = (from c in contexto.ClienteSet
                                    select new ClienteDTO
                                    {
                                        Id_Cliente = c.Id_Cliente,
                                    }).ToList();


            return ListaClientesOS;

        }
    }
}
