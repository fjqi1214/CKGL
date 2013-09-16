using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class CKGLContext:DbContext
    {
        public DbSet<CheckRecordTable> CheckRecords { get; set; }

        public DbSet<ExportStorageTable> ExportStorages { get; set; }

        public DbSet<ImportStorageTable> ImportStorages { get; set; }

        public DbSet<ManufacturerTable> Manufacturers { get; set; }

        public DbSet<ProductTable> Products { get; set; }

        public DbSet<StorageLocationTable> StorageLocations { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
           
            modelBuilder.Entity<CheckRecordTable>().HasKey(i => new { i.Id });
            modelBuilder.Entity<ExportStorageTable>().HasKey(i => new { i.Id });
            modelBuilder.Entity<ImportStorageTable>().HasKey(i => new { i.Id });
            modelBuilder.Entity<ManufacturerTable>().HasKey(i => new { i.ManufacturerName });
            modelBuilder.Entity<ProductTable>().HasKey(i => new { i.ProductName });
            modelBuilder.Entity<StorageLocationTable>().HasKey(i => new { i.LocationName });
            modelBuilder.Entity<User>().HasKey(i => new { i.UserName });

            base.OnModelCreating(modelBuilder);
        }

    }
}
