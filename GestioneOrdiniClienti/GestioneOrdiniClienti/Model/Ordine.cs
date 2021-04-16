using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GestioneOrdiniClienti.Model
{
    [DataContract]
    public class Ordine
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public DateTime DataOrdine { get; set; } = DateTime.Now;
        [DataMember]
        public string CodiceOrdine { get; set; }
        [DataMember]
        public string CodiceProdotto { get; set; }
        [DataMember]
        public decimal Importo { get; set; }

        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            return $"Ordine Data: {DataOrdine.ToShortDateString()} " +
                     $"- Cod. Ordine: {CodiceOrdine} " +
                     $"- Cod. Prodotto: {CodiceProdotto} " +
                     $"- Importo: {Importo} " +
                     $"- Cod. Cliente: {Cliente.CodiceCliente}";
        }
    }
}
