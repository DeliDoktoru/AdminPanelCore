﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelEntities : DbContext
    {
        public ModelEntities()
            : base("name=ModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dillers> Dillers { get; set; }
        public virtual DbSet<DilParametreleris> DilParametreleris { get; set; }
        public virtual DbSet<Kullanıcılars> Kullanıcılars { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Tablolars> Tablolars { get; set; }
        public virtual DbSet<YetkiGrubus> YetkiGrubus { get; set; }
    }
}
