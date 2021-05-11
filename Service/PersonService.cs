using BileApi.Data;
using BileApi.Extensions;
using BileApi.Models;
using BileApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BileApi.Service
{
    public class PersonService: IPersonService
    {
     
        private readonly IRepository<Person> _repository;

        public PersonService(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public int Create(Person person)
        {
            person.MyHappyDate = person.DateOfBirth.HappyDate();
            return _repository.Create(person);
        }

        public List<Person> Read()
        {
            return _repository.Read();
        }

        public int Update(int id, Person person) {
            return _repository.Update(id, person);
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
