using Backend.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Context
{
    public abstract class BaseDbContext : DbContext
    {
        protected BaseDbContext()
        {
        }

        protected BaseDbContext(DbContextOptions options) : base(options)
        {
        }
        protected static void ConfigureModelBinding<TO, TI>(ModelBuilder modelBuilder) where TO : class
        {
            SetPrimaryKeys<TO, TI>(modelBuilder);
        }

        private static void SetPrimaryKeys<TO, TI>(ModelBuilder modelBuilder) where TO : class
        {
            //Check the Interfaces and choose the correct binder
            if (typeof(IEntity<TI>).IsAssignableFrom(typeof(TO)))
            {
                modelBuilder.Entity<TO>().HasKey(c => ((IEntity<TI>)c).Id);
            }
        }

    }
}
