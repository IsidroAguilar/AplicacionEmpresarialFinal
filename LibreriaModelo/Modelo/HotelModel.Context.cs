﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreriaModelo.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelEntities : DbContext
    {
        public HotelEntities()
            : base("name=HotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<LoginAdm> LoginAdm { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Platillos> Platillos { get; set; }
        public virtual DbSet<Restaurantes> Restaurantes { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
