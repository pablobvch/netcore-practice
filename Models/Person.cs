using BileApi.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BileApi.Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
              
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MyHappyDate { get; set; }

        public List<Credential> Credentials { get; set; }
    }
}
