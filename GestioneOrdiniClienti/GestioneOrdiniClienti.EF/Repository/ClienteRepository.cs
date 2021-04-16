using GestioneOrdiniClienti.EF.Context;
using GestioneOrdiniClienti.Model;
using GestioneOrdiniClienti.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneOrdiniClienti.EF.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        //Dependency Injection
        private readonly OrdiniClientiContext ctx;
        public ClienteRepository() : this(new OrdiniClientiContext()) { }
        public ClienteRepository(OrdiniClientiContext ctx)
        {
            this.ctx = ctx;
        }

        //Implementazione Metodi CRUD
        public bool Create(Cliente item)
        {
            try
            {
                ctx.Clienti.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Cliente item)
        {
            try
            {
                var cDel = ctx.Clienti.Find(item.ID);
                if (cDel != null)
                {
                    ctx.Clienti.Remove(item);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            return ctx.Clienti.ToList();
        }

        public Cliente GetById(int id)
        {
            try
            {
                return ctx.Clienti.Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(Cliente item)
        {
            try
            {
                ctx.Clienti.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
