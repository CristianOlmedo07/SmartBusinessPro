using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EFSmarBisnessPro
{
    public class SmartBusinessContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<proveedor> Proveedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SmartBusinessDB"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producto>().HasKey(p => p.ProductoId);
            modelBuilder.Entity<Categoria>().HasKey(c => c.CategoriaId);
            modelBuilder.Entity<proveedor>().HasKey(p => p.ProveedorId);
        }
    }
}
