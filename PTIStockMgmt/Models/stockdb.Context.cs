﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTIStockMgmt.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StockDBEntities : DbContext
    {
        public StockDBEntities()
            : base("name=StockDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<active_assets> active_assets { get; set; }
        public DbSet<asset> assets { get; set; }
        public DbSet<location> locations { get; set; }
        public DbSet<transaction> transactions { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<assembly> assemblies { get; set; }
        public DbSet<assembly_assets> assembly_assets { get; set; }
    }
}
