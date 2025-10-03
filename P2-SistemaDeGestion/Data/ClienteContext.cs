using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2_SistemaDeGestion.Models;

namespace P2_SistemaDeGestion.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext (DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<P2_SistemaDeGestion.Models.Cliente> Cliente { get; set; } = default!;

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
        }
    }
}
