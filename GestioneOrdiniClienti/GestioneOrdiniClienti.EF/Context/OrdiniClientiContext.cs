using GestioneOrdiniClienti.EF.Configuration;
using GestioneOrdiniClienti.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdiniClienti.EF.Context
{
    public class OrdiniClientiContext : DbContext
    {
        public OrdiniClientiContext() : base() { }
        public OrdiniClientiContext(DbContextOptions<OrdiniClientiContext> options) : base(options) { }

        //Tabelle
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Ordine> Ordini { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False;
                                          Integrated Security = true;
                                          Initial Catalog = GestioneOrdClienti;
                                          Server = .\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfig());
            modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfig());
        }
    }
}
