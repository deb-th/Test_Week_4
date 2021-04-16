using GestioneOrdiniClienti.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdiniClienti.EF.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //Attributi
            builder.HasKey(c => c.ID);
            builder.Property(c => c.CodiceCliente).IsRequired();
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Cognome).IsRequired(false);

            //Relazione
            builder.HasMany(c => c.Ordini).WithOne(o => o.Cliente);
        }
    }
}