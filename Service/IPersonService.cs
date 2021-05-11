using BileApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BileApi.Service
{
    public interface IPersonService
    {
        public int Create(Person person);

        public List<Person> Read();

        public Person ReadById(int id);

        public int Update(int id, Person person);
        public int Delete(int id);

        
    }
}
