using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoEstoque.WebApi.Repositories.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T Find(int id);
        IQueryable<T> List();
        void Add(T item);
        void Delete(T item);
        void Edit(T item);
        void Save(T item);
    }
}
