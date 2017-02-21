using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ORMDEMO
{
    public class Model : DbContext
    {
        public DbSet<UpdateTable> Updates { get; set; }
        public DbSet<ProductTable> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ORMPROJECT");
        }
    }
}