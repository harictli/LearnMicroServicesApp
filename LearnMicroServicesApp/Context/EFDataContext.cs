using LearnMicroServicesApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMicroServicesApp.Context
{
    public class EFDataContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=testctli.database.windows.net; initial catalog=Test;persist security info=True;user id=harictli;password=Hari@5499;");
        }
    }
}
