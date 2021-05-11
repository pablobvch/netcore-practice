using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BileApi.Models;

namespace BileApi.Data
{
    public class BileApiContext : DbContext
    {
        public BileApiContext (DbContextOptions<BileApiContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   // optionsBuilder.UseLazyLoadingProxies();
        //}

        public DbSet<BileApi.Models.Person> Person { get; set; }
    }
}
