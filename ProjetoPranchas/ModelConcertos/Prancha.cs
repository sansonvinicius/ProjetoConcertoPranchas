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
    using ModelConcertosEntity;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public  class Prancha: BaseNotifyPropertyChanged , ICloneable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prancha()
        {
            this.OS = new HashSet<OS>();
        }


        private int _Id_Prancha;
        public int Id_Prancha
        {
            get { return _Id_Prancha; }
            set { SetField(ref _Id_Prancha, value); }
        }

        private string _Marca;
        public string Marca
        {
            get { return _Marca; }
            set { SetField(ref _Marca, value); }
        }

        private string _Modelo;
        public string Modelo
        {
            get { return _Modelo; }
            set { SetField(ref _Modelo, value); }
        }

        private string _Cor;
        public string Cor
        {
            get { return _Cor; }
            set { SetField(ref _Cor, value); }
        }

        private string _QtdQuilhas;
        public string QtdQuilhas
        {
            get { return _QtdQuilhas; }
            set { SetField(ref _QtdQuilhas, value); }
        }

        private string _Medida;
        public string Medida
        {
            get { return _Medida; }
            set { SetField(ref _Medida, value); }
        }


        public ObservableCollection<Prancha> Pranchas { get; set; } = new ObservableCollection<Prancha>();





        /*public int Id_Prancha { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string QtdQuilhas { get; set; }
        public string Medida { get; set; }*/

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OS> OS { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public abstract class BaseNotifyPropertyChanged : System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void SetField<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}