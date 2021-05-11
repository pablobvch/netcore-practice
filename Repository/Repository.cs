using BileApi.Data;
using BileApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BileApi.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BileApiContext _context;

        public Repository(BileApiContext context)
        {
            _context = context;
        }

        public int Create(T model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return model.Id;
        }

        public List<T> Read()
        {
            return _context.Set<T>().ToList();
        }

        public T ReadById(int id)
        {
            return _context.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public int Update(int id, T model)
        {
            model.Id = id;
            _context.Entry(model).State = EntityState.Modified;
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var itemToRemove = _context.Set<T>().SingleOrDefault(x => x.Id == id);
            var result = 0;
            if (itemToRemove != null)
            {
                _context.Set<T>().Remove(itemToRemove);
                result = _context.SaveChanges();
                return result;
            }
            return result;
        }
    }
}
