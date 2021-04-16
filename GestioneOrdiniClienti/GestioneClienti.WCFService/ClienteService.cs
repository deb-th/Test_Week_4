using GestioneClienti.WCFService;
using GestioneOrdiniClienti.EF.Repository;
using GestioneOrdiniClienti.Model;
using GestioneOrdiniClienti.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestioneClienti.WCFService
{ }
public class ClienteService : IClienteService
{

    //introduzione di un membro privato di repository
    //per richiamare l'implementazione dei metodi
    //presenti in un altro livello
    private IClienteRepository clienteRepository = new ClienteRepository();


    //Metodi CRUD per gestione Cliente
    public bool AddNewCliente(Cliente cliente)
    {
        return clienteRepository.Create(cliente);
    }

    public bool DeleteCliente(Cliente cliente)
    {
        return clienteRepository.Delete(cliente);
    }

    public string GetAllClienti()
    {
        var clienti = clienteRepository.GetAll();
        foreach (var cl in clienti)
        {
            return cl.ToString();
        }
        return "Lista vuota!";
    }

    public string GetCliente(int id)
    {
        var cl = clienteRepository.GetById(id);
        if (cl == null)
        {
            return "Cliente NON Trovato!";
        }
        return cl.ToString();
    }

    public bool UpdateCliente(Cliente cliente)
    {
        return clienteRepository.Update(cliente);
    }
}