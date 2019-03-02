using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IDal<T> where T:class
    {
        void GetAll();
        void GetById(int id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(int id);
    }
}
