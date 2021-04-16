using GestioneOrdiniClienti.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdiniClienti.EF.Configuration
{
    public class OrdineConfig : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            //Attributi
            builder.HasKey(o => o.ID);
            builder.Property(o => o.CodiceOrdine).IsRequired();
            builder.Property(o => o.DataOrdine).IsRequired();
            builder.Property(o => o.CodiceProdotto).IsRequired();
            builder.Property(o => o.Importo).IsRequired();

            //Relazione
            builder.HasOne(o => o.Cliente).WithMany(c => c.Ordini);
        }
    }

}
