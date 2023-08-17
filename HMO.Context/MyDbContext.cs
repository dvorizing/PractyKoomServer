using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Context
{
    public class MyDbContext: DbContext, IContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Child> Childs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hmo;Trusted_Connection=True");
        }
    }
}
