using BileApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BileApi.Repository
{
    public interface IRepository<T>
    {
        public int Create(T model);

        public List<T> Read();

        public T ReadById(int id);

        public int Update(int id, T model);
        public int Delete(int id);
    }
}
