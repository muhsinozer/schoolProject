﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GzAutomation.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GuzellikSalonuEntities : DbContext
    {
        public GuzellikSalonuEntities()
            : base("name=GuzellikSalonuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Borclar> Borclars { get; set; }
        public DbSet<IslemKaydi> IslemKaydis { get; set; }
        public DbSet<Kullanicilar> Kullanicilars { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Randevular> Randevulars { get; set; }
    }
}
