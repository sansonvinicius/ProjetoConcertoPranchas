﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelConcertosEntityContainer : DbContext
    {
        public ModelConcertosEntityContainer()
            : base("name=ModelConcertosEntityContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Prancha> PranchaSet { get; set; }
        public virtual DbSet<Cliente> ClienteSet { get; set; }
        public virtual DbSet<OS> OSSet { get; set; }
    }
}
