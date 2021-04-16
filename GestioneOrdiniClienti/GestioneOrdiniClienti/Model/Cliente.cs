using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GestioneOrdiniClienti.Model
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string CodiceCliente { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Cognome { get; set; }

        public List<Ordine> Ordini { get; set; }

        public override string ToString()
        {
            return $"Cliente Cod: {CodiceCliente} " +
                     $"- Nome: {Nome} " +
                     $"Cognome: {Cognome} ";
        }
    }
}
