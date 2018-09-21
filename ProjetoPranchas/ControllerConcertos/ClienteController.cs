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


        public void InserirCliente(Cliente cliente)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            contexto.ClienteSet.Add(cliente);
            contexto.SaveChanges();

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

        public void ExcluirCliente(int Id_Cliente)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

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
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

            //Procura por id e atualiza os dados em novoDadosPerson
            Cliente clienteAntigo = BuscarClientePorId(Id_Cliente);

            if (clienteAntigo != null)
            {
                try { 
                clienteAntigo.Nome= novosDadosCliente.Nome;
                clienteAntigo.Sobrenome = novosDadosCliente.Sobrenome;
                clienteAntigo.Cpf = novosDadosCliente.Cpf;
                clienteAntigo.Telefone = novosDadosCliente.Telefone;
                clienteAntigo.Email = novosDadosCliente.Email;
                clienteAntigo.Endereco = novosDadosCliente.Endereco;
               
                contexto.Entry(clienteAntigo).State = System.Data.Entity.EntityState.Modified;
                   
                }       

                catch (System.Exception)
                {

                }

                contexto.SaveChanges();



            }
        }
    }
}
