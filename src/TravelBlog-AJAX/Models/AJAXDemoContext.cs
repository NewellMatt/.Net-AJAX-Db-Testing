using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace AjaxDemo.Models
{
    public class AjaxDemoContext : DbContext
    {
        public virtual DbSet<Person> Destinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AjaxDemo;integrated security = True");
        }
    }
}
