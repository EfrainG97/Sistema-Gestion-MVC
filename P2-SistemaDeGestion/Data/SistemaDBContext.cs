using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2_SistemaDeGestion.Models;

namespace P2_SistemaDeGestion.Data
{
    public class SistemaDBContext : DbContext
    {
        public SistemaDBContext (DbContextOptions<SistemaDBContext> options)
            : base(options)
        {
        }

        public DbSet<P2_SistemaDeGestion.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<P2_SistemaDeGestion.Models.Producto> Producto { get; set; } = default!;
        public DbSet<P2_SistemaDeGestion.Models.Marca> Marca { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "Juan", ApellidoPaterno = "Pérez", ApellidoMaterno = "Gómez", Telefono = "555-1234" },
                new Cliente { Id = 2, Nombre = "Ana", ApellidoPaterno = "López", ApellidoMaterno = "Martínez", Telefono = "555-5678" },
                new Cliente { Id = 3, Nombre = "Luis", ApellidoPaterno = "Ramírez", ApellidoMaterno = "Santos", Telefono = "555-8765" },
                new Cliente { Id = 4, Nombre = "María", ApellidoPaterno = "Torres", ApellidoMaterno = "Vega", Telefono = "555-4321" },
                new Cliente { Id = 5, Nombre = "Carlos", ApellidoPaterno = "Hernández", ApellidoMaterno = "Ruiz", Telefono = "555-2468" }
            );

            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, IdMarca = 1, Nombre = "Laptop", Descripcion = "Portátil 15''", Precio = 12000, Existencia = 10 },
                new Producto { Id = 2, IdMarca = 2, Nombre = "Mouse", Descripcion = "Mouse óptico", Precio = 250, Existencia = 50 },
                new Producto { Id = 3, IdMarca = 3, Nombre = "Teclado", Descripcion = "Teclado mecánico", Precio = 800, Existencia = 30 },
                new Producto { Id = 4, IdMarca = 4, Nombre = "Monitor", Descripcion = "Monitor 24''", Precio = 3500, Existencia = 15 },
                new Producto { Id = 5, IdMarca = 4, Nombre = "Impresora", Descripcion = "Impresora láser", Precio = 2200, Existencia = 8 }
            );

            modelBuilder.Entity<Marca>().HasData(
                new Marca { Id = 1, Descripcion = "HP" },
                new Marca { Id = 2, Descripcion = "Lenovo" },
                new Marca { Id = 3, Descripcion = "Logitech" },
                new Marca { Id = 4, Descripcion = "DELL" },
                new Marca { Id = 5, Descripcion = "Nike" }
            );
        }
        
    }
}
