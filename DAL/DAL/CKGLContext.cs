﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class CKGLContext:DbContext
    {
        public DbSet<CheckRecord> CheckRecords { get; set; }

        public DbSet<ExportStorage> ExportStorages { get; set; }

        public DbSet<ImportStorage> ImportStorages { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<StorageLocation> StorageLocations { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
           
            modelBuilder.Entity<CheckRecord>().HasKey(i => new { i.Id });
            modelBuilder.Entity<ExportStorage>().HasKey(i => new { i.Id });
            modelBuilder.Entity<ImportStorage>().HasKey(i => new { i.Id });
            modelBuilder.Entity<Manufacturer>().HasKey(i => new { i.ManufacturerName });
            modelBuilder.Entity<Product>().HasKey(i => new { i.ProductName });
            modelBuilder.Entity<StorageLocation>().HasKey(i => new { i.LocationName });
            modelBuilder.Entity<User>().HasKey(i => new { i.UserName });

            base.OnModelCreating(modelBuilder);
        }

    }
}
