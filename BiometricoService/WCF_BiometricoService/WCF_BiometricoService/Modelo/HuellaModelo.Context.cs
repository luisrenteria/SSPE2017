﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_BiometricoService.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HuellasEntities : DbContext
    {
        public HuellasEntities()
            : base("name=HuellasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<PERSONA> PERSONA { get; set; }
        public DbSet<PERSONA_BIOMETRICO> PERSONA_BIOMETRICO { get; set; }
        public DbSet<BIOMETRICO_FORMATO> BIOMETRICO_FORMATO { get; set; }
        public DbSet<BIOMETRICO_TIPO> BIOMETRICO_TIPO { get; set; }
        public DbSet<IMPUTADO_BM> IMPUTADO { get; set; }
        public DbSet<INGRESO_BM> INGRESO { get; set; }
        public DbSet<IMPUTADO_BIOMETRICO> IMPUTADO_BIOMETRICO { get; set; }
    }
}
