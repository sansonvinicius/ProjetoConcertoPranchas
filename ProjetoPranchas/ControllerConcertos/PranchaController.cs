﻿
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
   public class PranchaController
    {
        ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();

        public ObservableCollection<Prancha> GetPrancha()
        {
            return new ObservableCollection<Prancha>(contexto.PranchaSet.ToList());
        }
        public void InserirPrancha(Prancha prancha)
        {
            ModelConcertosEntityContainer contexto = new ModelConcertosEntityContainer();
            contexto.PranchaSet.Add(prancha);
            contexto.SaveChanges();

        }
        Prancha BuscarPranchaPorId(int Id_Prancha)
        {
            return contexto.PranchaSet.Find(Id_Prancha);

        }

        public void ExcluirPrancha(int Id_Prancha)
        {

            Prancha pExcluir = BuscarPranchaPorId(Id_Prancha);
            pExcluir = contexto.PranchaSet.Where(p => p.Id_Prancha == pExcluir.Id_Prancha).FirstOrDefault();

            if (pExcluir != null)
            {

                contexto.PranchaSet.Remove(pExcluir);
                contexto.SaveChanges();


            }
        }

        public void EditarPrancha(int Id_Prancha, Prancha novosDadosPrancha)
        {

            //Procura por id e atualiza os dados em novoDadosPerson
            Prancha pranchaAntiga = BuscarPranchaPorId(Id_Prancha);

            if (pranchaAntiga != null)
            {
                pranchaAntiga.Modelo = novosDadosPrancha.Modelo;
                pranchaAntiga.Marca = novosDadosPrancha.Marca;
                pranchaAntiga.Medida = novosDadosPrancha.Medida;
                pranchaAntiga.Cor = novosDadosPrancha.Cor;
                pranchaAntiga.QtdQuilhas = novosDadosPrancha.QtdQuilhas;

                contexto.Entry(pranchaAntiga).State = System.Data.Entity.EntityState.Modified;


                contexto.SaveChanges();



            }
        }


    }
}
