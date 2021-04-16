using GestioneOrdiniClienti.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdiniClienti.BusinessLayer
{
    public interface IGestioneOrdClientiBL
    {
        //Centralizzo tutti i metodi CRUD
        //per la gestione degli ordini
        //e anche dei clienti

        bool CreateCliente(Cliente newCliente);
        IEnumerable<Cliente> GetAllClienti();
        Cliente GetClienteById(int id);
        bool UpdateCliente(Cliente cliente);
        bool DeleteCliente(Cliente cliente);

        bool CreateOrdine(Ordine newOrdine);
        IEnumerable<Ordine> GetAllOrdini();
        Ordine GetOrdineById(int id);
        bool UpdateOrdine(Ordine ordine);
        bool DeleteOrdine(Ordine ordine);
    }
}
