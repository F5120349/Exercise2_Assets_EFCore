using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Exercise2_Assets_EFCore.Data
{
    public class AssetsDbContext: DbContext
    {
        public string DbPath { get; }

        public AssetsDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "assets.db");
        }

        public DbSet<Assets> Assets => Set<Assets>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add test data
            modelBuilder.Entity<Assets>().HasData(
                new Assets
                {
                    Id = 1,
                    Name = "Laptop",
                    Location = "Office",
                    DateAcquired = new DateOnly(2022, 1, 15),
                    InUse = true,
                    PurchasePrice = 1200.00m
                },
                new Assets
                {
                    Id = 2,
                    Name = "Projector",
                    Location = "Conference Room",
                    DateAcquired = new DateOnly(2021, 5, 10),
                    InUse = false,
                    PurchasePrice = 800.00m
                }
            );
        }
    }
}
