﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 05.12.2018 12:30:29
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Reflection;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Model
{

    public partial class ModelModel : DbContext
    {

        public ModelModel() :
            base()
        {
            OnCreated();
        }

        public ModelModel(DbContextOptions<ModelModel> options) :
            base(options)
        {
            OnCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured ||
                (!optionsBuilder.Options.Extensions.OfType<RelationalOptionsExtension>().Any(ext => !string.IsNullOrEmpty(ext.ConnectionString) || ext.Connection != null) &&
                 !optionsBuilder.Options.Extensions.Any(ext => !(ext is RelationalOptionsExtension) && !(ext is CoreOptionsExtension))))
            {
                optionsBuilder.UseNpgsql(GetConnectionString("ModelModelConnectionString"));
                optionsBuilder.UseLazyLoadingProxies();
            }
            CustomizeConfiguration(ref optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        private static string GetConnectionString(string connectionStringName)
        {
            System.Configuration.ConnectionStringSettings connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName];
            if (connectionStringSettings == null)
                throw new InvalidOperationException("Connection string \"" + connectionStringName +"\" could not be found in the configuration file.");
            return connectionStringSettings.ConnectionString;
        }

        partial void CustomizeConfiguration(ref DbContextOptionsBuilder optionsBuilder);

        public virtual DbSet<Diller> Dillers
        {
            get;
            set;
        }

        public virtual DbSet<DilParametreleri> DilParametreleris
        {
            get;
            set;
        }

        public virtual DbSet<Tablolar> Tablolars
        {
            get;
            set;
        }

        public virtual DbSet<Menu> Menus
        {
            get;
            set;
        }

        public virtual DbSet<Kullanıcılar> Kullanıcılars
        {
            get;
            set;
        }

        public virtual DbSet<YetkiGrubu> YetkiGrubus
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.DillerMapping(modelBuilder);
            this.CustomizeDillerMapping(modelBuilder);

            this.DilParametreleriMapping(modelBuilder);
            this.CustomizeDilParametreleriMapping(modelBuilder);

            this.TablolarMapping(modelBuilder);
            this.CustomizeTablolarMapping(modelBuilder);

            this.MenuMapping(modelBuilder);
            this.CustomizeMenuMapping(modelBuilder);

            this.KullanıcılarMapping(modelBuilder);
            this.CustomizeKullanıcılarMapping(modelBuilder);

            this.YetkiGrubuMapping(modelBuilder);
            this.CustomizeYetkiGrubuMapping(modelBuilder);

            RelationshipsMapping(modelBuilder);
            CustomizeMapping(ref modelBuilder);
        }

        #region Diller Mapping

        private void DillerMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diller>().ToTable(@"Dillers", @"public");
            modelBuilder.Entity<Diller>().Property<long>(x => x.ID).HasColumnName(@"ID").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Diller>().Property<string>(x => x.Ad).HasColumnName(@"Ad").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Diller>().HasKey(@"ID");
        }

        partial void CustomizeDillerMapping(ModelBuilder modelBuilder);

        #endregion

        #region DilParametreleri Mapping

        private void DilParametreleriMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DilParametreleri>().ToTable(@"DilParametreleris", @"public");
            modelBuilder.Entity<DilParametreleri>().Property<long>(x => x.ID).HasColumnName(@"ID").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<DilParametreleri>().Property<string>(x => x.Kodu).HasColumnName(@"Kodu").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<DilParametreleri>().Property<long>(x => x.Dili).HasColumnName(@"Dili").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<DilParametreleri>().HasKey(@"ID");
        }

        partial void CustomizeDilParametreleriMapping(ModelBuilder modelBuilder);

        #endregion

        #region Tablolar Mapping

        private void TablolarMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tablolar>().ToTable(@"Tablolars", @"public");
            modelBuilder.Entity<Tablolar>().Property<long>(x => x.ID).HasColumnName(@"ID").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Tablolar>().Property<string>(x => x.Ad).HasColumnName(@"Ad").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Tablolar>().HasKey(@"ID");
        }

        partial void CustomizeTablolarMapping(ModelBuilder modelBuilder);

        #endregion

        #region Menu Mapping

        private void MenuMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().ToTable(@"Menus", @"public");
            modelBuilder.Entity<Menu>().Property<long>(x => x.ID).HasColumnName(@"ID").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Menu>().Property<long>(x => x.Tablo).HasColumnName(@"Tablo").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Menu>().Property<string>(x => x.Sıra).HasColumnName(@"Sıra").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Menu>().HasKey(@"ID");
        }

        partial void CustomizeMenuMapping(ModelBuilder modelBuilder);

        #endregion

        #region Kullanıcılar Mapping

        private void KullanıcılarMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanıcılar>().ToTable(@"Kullanıcılars", @"public");
            modelBuilder.Entity<Kullanıcılar>().Property<long>(x => x.ID).HasColumnName(@"ID").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Kullanıcılar>().Property<string>(x => x.Ad).HasColumnName(@"Ad").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Kullanıcılar>().Property<string>(x => x.Email).HasColumnName(@"Email").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Kullanıcılar>().Property<string>(x => x.Şifre).HasColumnName(@"Şifre").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Kullanıcılar>().Property<long>(x => x.Yetki).HasColumnName(@"Yetki").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<Kullanıcılar>().HasKey(@"ID");
            modelBuilder.Entity<Kullanıcılar>().HasIndex(@"Ad").IsUnique(true);
            modelBuilder.Entity<Kullanıcılar>().HasIndex(@"Email").IsUnique(true);
            modelBuilder.Entity<Kullanıcılar>().HasIndex(@"Yetki").IsUnique(true);
        }

        partial void CustomizeKullanıcılarMapping(ModelBuilder modelBuilder);

        #endregion

        #region YetkiGrubu Mapping

        private void YetkiGrubuMapping(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YetkiGrubu>().ToTable(@"YetkiGrubus", @"public");
            modelBuilder.Entity<YetkiGrubu>().Property<long>(x => x.ID).HasColumnName(@"ID").HasColumnType(@"int8").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<YetkiGrubu>().Property<string>(x => x.Ad).HasColumnName(@"Ad").HasColumnType(@"varchar").IsRequired().ValueGeneratedNever();
            modelBuilder.Entity<YetkiGrubu>().HasKey(@"ID");
            modelBuilder.Entity<YetkiGrubu>().HasIndex(@"Ad").IsUnique(true);
        }

        partial void CustomizeYetkiGrubuMapping(ModelBuilder modelBuilder);

        #endregion

        private void RelationshipsMapping(ModelBuilder modelBuilder)
        {

        #region Diller Navigation properties

            modelBuilder.Entity<Diller>().HasMany(x => x.DilParametreleris).WithOne(op => op.Diller).IsRequired(true).HasForeignKey(@"Dili");

        #endregion

        #region DilParametreleri Navigation properties

            modelBuilder.Entity<DilParametreleri>().HasOne(x => x.Diller).WithMany(op => op.DilParametreleris).IsRequired(true).HasForeignKey(@"Dili");

        #endregion

        #region Tablolar Navigation properties

            modelBuilder.Entity<Tablolar>().HasMany(x => x.Menus).WithOne(op => op.Tablolar).IsRequired(true).HasForeignKey(@"Tablo");

        #endregion

        #region Menu Navigation properties

            modelBuilder.Entity<Menu>().HasOne(x => x.Tablolar).WithMany(op => op.Menus).IsRequired(true).HasForeignKey(@"Tablo");

        #endregion

        #region Kullanıcılar Navigation properties

            modelBuilder.Entity<Kullanıcılar>().HasMany(x => x.YetkiGrubus).WithOne(op => op.Kullanıcılar).IsRequired(true).HasPrincipalKey(@"Yetki").HasForeignKey(@"ID");

        #endregion

        #region YetkiGrubu Navigation properties

            modelBuilder.Entity<YetkiGrubu>().HasOne(x => x.Kullanıcılar).WithMany(op => op.YetkiGrubus).IsRequired(true).HasPrincipalKey(@"Yetki").HasForeignKey(@"ID");

        #endregion
        }

        partial void CustomizeMapping(ref ModelBuilder modelBuilder);

        public bool HasChanges()
        {
            return ChangeTracker.Entries().Any(e => e.State == Microsoft.EntityFrameworkCore.EntityState.Added || e.State == Microsoft.EntityFrameworkCore.EntityState.Modified || e.State == Microsoft.EntityFrameworkCore.EntityState.Deleted);
        }

        partial void OnCreated();
    }
}
