using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class NortwindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SELIM-BAYINDIR\ARC;Initial Catalog=PerDb;User ID=sa;Password=Perkon123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
               ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        }

        public DbSet<Person> People{ get; set; }
        public DbSet<Company> Companies{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<TaskFeature> TaskFeatures{ get; set; }
        public DbSet<Permission> Permissions{ get; set; }
    }
}
