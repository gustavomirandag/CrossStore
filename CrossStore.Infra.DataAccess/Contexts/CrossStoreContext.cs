using CrossStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossStore.Infra.DataAccess.Contexts
{
    public class CrossStoreContext : DbContext
    {
        private readonly string dbConnectionString;
        public DbSet<Product> Products { get; set; }

        public CrossStoreContext(string dbConnectionString)
        {
            this.dbConnectionString = dbConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(dbConnectionString);
        }
    }
}
