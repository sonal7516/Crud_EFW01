using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_EFW01.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(): 
            base("Data Source=CHETUIWK1901\\SQLEXPRESS;Initial Catalog=CRUDdb01;Integrated Security=True;Pooling=False") { }

        public DbSet<Employee> Employees { get; set; }
    }
}