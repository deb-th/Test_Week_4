using GestioneOrdiniClienti.EF.Context;
using GestioneOrdiniClienti.Model;
using GestioneOrdiniClienti.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneOrdiniClienti.EF.Repository
{
    public class OrdineRepository : IOrdineRepository
    {
        //Dependency Injection
        private readonly OrdiniClientiContext ctx;
        public OrdineRepository() : this(new OrdiniClientiContext()) { }
        public OrdineRepository(OrdiniClientiContext ctx)
        {
            this.ctx = ctx;
        }

        //Implementazione Metodi CRUD
        public bool Create(Ordine item)
        {
            try
            {
                ctx.Ordini.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Ordine item)
        {
            try
            {
                var oDel = ctx.Ordini.Find(item.ID);
                if (oDel != null)
                {
                    ctx.Ordini.Remove(item);
                }
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Ordine> GetAll()
        {
            return ctx.Ordini.ToList();
        }

        public Ordine GetById(int id)
        {
            try
            {
                return ctx.Ordini.Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Update(Ordine item)
        {
            try
            {
                ctx.Ordini.Update(item);
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
