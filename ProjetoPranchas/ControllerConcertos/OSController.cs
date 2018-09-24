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
    public class OSController
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

        public ObservableCollection<OS> GetOS()
        {
            return new ObservableCollection<OS>(contexto.OSSet.ToList());
        }

        public void InserirOs(OS os)
        {
                
                contexto.OSSet.Add(os);
                //contexto.SaveChanges();
            
           

        }
        OS BuscarOsPorId(int Id_Os)
        {
            return contexto.OSSet.Find(Id_Os);

        }

        public void ExcluirOs(int Id_OS)
        {

            OS oExcluir = BuscarOsPorId(Id_OS);
            oExcluir = contexto.OSSet.Where(o => o.Id_OS == oExcluir.Id_OS).FirstOrDefault();

            if (oExcluir != null)
            {

                contexto.OSSet.Remove(oExcluir);
                contexto.SaveChanges();


            }
        }

        public void EditarOS(int Id_OS, OS novosDadosOS)
        {

            OS osAntiga = BuscarOsPorId(Id_OS);

            if (osAntiga != null)
            {
                osAntiga.Descricao = novosDadosOS.Descricao;
                osAntiga.Valor = novosDadosOS.Valor;
                osAntiga.Data_Entrada = novosDadosOS.Data_Entrada;
                osAntiga.Data_Saida = novosDadosOS.Data_Saida;
                osAntiga.Status = novosDadosOS.Status;
                osAntiga.Situacao = novosDadosOS.Situacao;
                osAntiga.ClienteId_Cliente = novosDadosOS.ClienteId_Cliente;
                osAntiga.PranchaId_Prancha = novosDadosOS.PranchaId_Prancha;

                contexto.Entry(osAntiga).State = System.Data.Entity.EntityState.Modified;


                contexto.SaveChanges();

            }
        }




        public List<OsDTO> OSsFinalizadas()
        {



            var listaFinalizadas = (from os in contexto.OSSet
                                  join p in contexto.PranchaSet on os.PranchaId_Prancha equals p.Id_Prancha
                                  join c in contexto.ClienteSet on os.ClienteId_Cliente equals c.Id_Cliente
                                  where os.Status == "Finalizado"
                                  select new OsDTO
                                  {
                                      Id_OS = os.Id_OS,
                                      Descricao = os.Descricao,
                                      Valor = os.Valor,
                                      Data_Entrada = os.Data_Entrada,
                                      Data_Saida = os.Data_Saida,
                                      Status = os.Status,
                                      Situacao = os.Situacao,
                                      Nome = c.Nome,
                                      Marca = p.Marca,

                                  }).ToList();



            return listaFinalizadas;
          
        }

        public List<OsDTO> OSsAndamento()
        {



            var listaAndamento = (from os in contexto.OSSet
                                    join p in contexto.PranchaSet on os.PranchaId_Prancha equals p.Id_Prancha
                                    join c in contexto.ClienteSet on os.ClienteId_Cliente equals c.Id_Cliente
                                    where os.Status != "Finalizado"
                                    select new OsDTO
                                    {
                                        Id_OS = os.Id_OS,
                                        Descricao = os.Descricao,
                                        Valor = os.Valor,
                                        Data_Entrada = os.Data_Entrada,
                                        Status = os.Status,
                                        Situacao = os.Situacao,
                                        Nome = c.Nome,
                                        Marca = p.Marca,

                                    }).ToList();


            return listaAndamento;

        }



    }
}

  