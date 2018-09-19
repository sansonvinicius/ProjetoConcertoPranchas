//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelConcertosEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class OS : BaseNotifyPropertyChanged, ICloneable
    {


        private int _Id_OS;
        public int Id_OS
        {
            get { return _Id_OS; }
            set { SetField(ref _Id_OS, value); }
        }

        private string _Descricao;
        public string Descricao
        {
            get { return _Descricao; }
            set { SetField(ref _Descricao, value); }
        }

        private decimal _Valor;
        public decimal Valor
        {
            get { return _Valor; }
            set { SetField(ref _Valor, value); }
        }
        [Required]
        private DateTime? _Data_Entrada;
        public DateTime? Data_Entrada
        {
            get { return _Data_Entrada; }
            set { SetField(ref _Data_Entrada, value); }
        }
        [Required]
        private DateTime? _Data_Saida;
        public DateTime? Data_Saida
        {
            get { return _Data_Saida; }
            set { SetField(ref _Data_Saida, value); }
        }

        private string _Status;
        public string Status
        {
            get { return _Status; }
            set { SetField(ref _Status, value); }
        }

        private string _Situacao;
        public string Situacao
        {
            get { return _Situacao; }
            set { SetField(ref _Situacao, value); }
        }

       /*private string _Cliente;
        public string Cliente
        {
            get { return _Cliente; }
            set { SetField(ref _Cliente, value); }
        }

        private string _Prancha;
        public string Prancha
        {
            get { return _Prancha; }
            set { SetField(ref _Prancha, value); }
        }*/

        public object Clone()
        {
            return this.MemberwiseClone();
        }



        /* public int Id_OS { get; set; }
         public string Descricao { get; set; }
         public decimal Valor { get; set; }
         public System.DateTime Data_Entrada { get; set; }
         public System.DateTime Data_Saida { get; set; }
         public string Status { get; set; }
         public string Situacao { get; set; }*/
         public int ClienteId_Cliente { get; set; }
         public int PranchaId_Prancha { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Prancha Prancha { get; set; }
        
    }
}
