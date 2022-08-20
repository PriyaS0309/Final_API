using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private DepartmentDbContext departmentDbContext;
        public DepartmentRepo(DepartmentDbContext departmentDbContext)
        {
            this.departmentDbContext = departmentDbContext;
        }

        public async Task<Department> GetDepartment(int ID)
        {
            return await departmentDbContext.Departments.FirstOrDefaultAsync(model => model.ID == ID);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await departmentDbContext.Departments.ToListAsync();
        }

        
    }
}
