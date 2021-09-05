using Backend.Context;
using Backend.Model;
using CarRent_Testat_SAD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRent_Testat_SAD.Entity
{
    public class CarRentEntities : BaseDbContext
    {


        private static string connString = "Data Source=LAPTOP-126TC3IU\\MSSQLSERVER19;" +
                  "Database=CarRent;" +
                   "Trusted_Connection = True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureModelBinding<Adresse, Guid>(modelBuilder);
            ConfigureModelBinding<Auto, Guid>(modelBuilder);
            ConfigureModelBinding<AutoKlasse, Guid>(modelBuilder);
            ConfigureModelBinding<Kunde, Guid>(modelBuilder);
            ConfigureModelBinding<Reservierung, Guid>(modelBuilder);
        }

        public virtual DbSet<Adresse> Adressen { get; set; }
        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<AutoKlasse> AutoKlassen { get; set; }
        public virtual DbSet<Kunde> Kunden { get; set; }
        public virtual DbSet<Reservierung> Reservierungen { get; set; }

    }
}
