using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public class DepartmentDbContext : DbContext
    {
        public DepartmentDbContext(DbContextOptions<DepartmentDbContext> options) : base(options)
        {

        }
      public  DbSet<Department> Departments { get; set; }
       public DbSet<Employee> Employees { get; set; }
    }
}
