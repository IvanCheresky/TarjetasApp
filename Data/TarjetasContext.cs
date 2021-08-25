using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TarjetasApp.Helpers;
using TarjetasApp.Models;

namespace TarjetasApp.Data
{
    public class TarjetasContext : DbContext
    {
        public TarjetasContext(DbContextOptions<TarjetasContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarjeta> Tarjeta { get; set; }
        public DbSet<Persona> Persona { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasData(new Usuario()
            {
                IdUsuario = 1,
                Nombre = "Ivan",
                NombreUsuario = "Ivan",
                Password = "Cheresky"
            });

            modelBuilder.Entity<Tarjeta>().HasData(new Tarjeta()
            {
                IdTarjeta = 1,
                IdPersona = 1,
                Nombre = "Ivan",
                Numero = "00000000",
                Limite = 100000,
                Marca = Marca.PERE,
                Tasa = TasaCalculator.CalcularTasaPorcentual(Marca.PERE, DateTime.Now),
                Titular = "Ivan",
                Vencimiento = DateTime.Now
            });

            modelBuilder.Entity<Persona>().HasData(new Persona()
            {
                IdPersona = 1,
                Nombre = "Ivan",
                Apellido = "Cheresky",
                Direccion = "Calle 123",
                DNI = "30303030"
            });
        }
    }
}
