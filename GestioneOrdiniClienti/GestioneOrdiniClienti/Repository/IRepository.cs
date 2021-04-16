using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneOrdiniClienti.Repository
{
    public interface IRepository<T>
    {
        //Metodi CRUD
        bool Create(T item);
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Update(T item);
        bool Delete(T item);
    }
}
