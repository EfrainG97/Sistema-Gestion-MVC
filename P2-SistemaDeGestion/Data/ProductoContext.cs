using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2_SistemaDeGestion.Models;

namespace P2_SistemaDeGestion.Data
{
    public class ProductoContext : DbContext
    {
        public ProductoContext (DbContextOptions<ProductoContext> options)
            : base(options)
        {
        }

        public DbSet<P2_SistemaDeGestion.Models.Producto> Producto { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Laptop", Descripcion = "Portátil 15''", Precio = 12000, Existencia = 10 },
                new Producto { Id = 2, Nombre = "Mouse", Descripcion = "Mouse óptico", Precio = 250, Existencia = 50 },
                new Producto { Id = 3, Nombre = "Teclado", Descripcion = "Teclado mecánico", Precio = 800, Existencia = 30 },
                new Producto { Id = 4, Nombre = "Monitor", Descripcion = "Monitor 24''", Precio = 3500, Existencia = 15 },
                new Producto { Id = 5, Nombre = "Impresora", Descripcion = "Impresora láser", Precio = 2200, Existencia = 8 }
            );
        }
    }
}
