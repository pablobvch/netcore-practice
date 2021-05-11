using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BileApi.Models
{
    public class BaseEntity
    {
        [Key] // Annotation for Primary Key for EF
        public int Id { get; set; }
    }
}
