using Backend.Model;
using CarRent_Testat_SAD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Context
{
    public class CarRentDbContext : BaseDbContext
    {
        public CarRentDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<AutoKlasse> AutoKlassen { get; set; }
        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Adresse> Adressen { get; set; }
        public DbSet<Reservierung> Reservierungen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureModelBinding<Auto, Guid>(modelBuilder);
            ConfigureModelBinding<AutoKlasse, Guid>(modelBuilder);
            ConfigureModelBinding<Kunde, Guid>(modelBuilder);
            ConfigureModelBinding<Adresse, Guid>(modelBuilder);
            ConfigureModelBinding<Reservierung, Guid>(modelBuilder);
        }
    }
}
