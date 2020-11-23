using GestaoEstoque.WebApi.Data;
using GestaoEstoque.WebApi.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GestaoEstoque.WebApi.Repositories
{
    public class BaseRepository<T>
    : IDisposable, IBaseRepository<T> where T : class
    {
        private Context _context;

        #region Ctor
        public BaseRepository(Context context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }
        #endregion

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> List()
        {
            return _context.Set<T>();
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public void Edit(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Save(T item) 
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
