using GestioneOrdiniClienti.Model;
using GestioneOrdiniClienti.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdiniClienti.BusinessLayer
{
    public class GestioneOrdClientiBL : IGestioneOrdClientiBL
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IOrdineRepository ordineRepository;

        public GestioneOrdClientiBL(IClienteRepository clienteRepo,
            IOrdineRepository ordineRepo)
        {
            this.clienteRepository = clienteRepo;
            this.ordineRepository = ordineRepo;
        }

        public bool CreateCliente(Cliente newCliente)
        {
            return clienteRepository.Create(newCliente);
        }

        public bool CreateOrdine(Ordine newOrdine)
        {
            return ordineRepository.Create(newOrdine);
        }

        public bool DeleteCliente(Cliente cliente)
        {
            return clienteRepository.Delete(cliente);
        }

        public bool DeleteOrdine(Ordine ordine)
        {
            return ordineRepository.Delete(ordine);
        }

        public IEnumerable<Cliente> GetAllClienti()
        {
            return clienteRepository.GetAll();
        }

        public IEnumerable<Ordine> GetAllOrdini()
        {
            return ordineRepository.GetAll();
        }

        public Cliente GetClienteById(int id)
        {
            return clienteRepository.GetById(id);
        }

        public Ordine GetOrdineById(int id)
        {
            return ordineRepository.GetById(id);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            return clienteRepository.Update(cliente);
        }

        public bool UpdateOrdine(Ordine ordine)
        {
            return ordineRepository.Update(ordine);
        }
    }
}