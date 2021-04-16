using GestioneOrdiniClienti.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestioneClienti.WCFService
{
    [ServiceContract]
    public interface IClienteService
    {
        //Cliente Service Operations

        [OperationContract]
        bool AddNewCliente(Cliente cliente);
        [OperationContract]
        bool DeleteCliente(Cliente cliente);
        [OperationContract]
        bool UpdateCliente(Cliente cliente);
        [OperationContract]
        string GetCliente(int id);
        [OperationContract]
        string GetAllClienti();
    }
}