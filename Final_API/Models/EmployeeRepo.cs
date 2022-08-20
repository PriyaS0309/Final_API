using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private DepartmentDbContext departmentDbContext;
        public EmployeeRepo(DepartmentDbContext departmentDbContext)
        {
            this.departmentDbContext = departmentDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
           var result= await departmentDbContext.Employees.AddAsync(employee);
            await departmentDbContext.SaveChangesAsync();
            return result.Entity;
        }

     

           public async Task<Employee> DeleteEmployee(int id)
           {
               var result = await departmentDbContext.Employees.FirstOrDefaultAsync(model => model.ID == id);

               if (result!=null)
               {
                  departmentDbContext.Employees.Remove(result);
                 await departmentDbContext.SaveChangesAsync();
               
               }
            return result;
           }

        public async Task<Employee> EditEmployee(Employee employee)
        {
            var result = await departmentDbContext.Employees.FirstOrDefaultAsync(model => model.ID == employee.ID);

            if(result!=null)
            {
                result.ID= employee.ID;
                result.Name = employee.Name;
                result.Email = employee.Email;
                result.Gender = employee.Gender;
                result.Department_DepartmentID = employee.Department_DepartmentID;

                await departmentDbContext.SaveChangesAsync();

               

            }
            return result;

        }

        public async Task<Employee> GetEmployee(int ID)
        {
            return await departmentDbContext.Employees.Include(model => model.Department).FirstOrDefaultAsync(model=>model.ID==ID);
        }

        public async Task<Employee> GetEmployeeByName(string Name)
        {
            return await departmentDbContext.Employees.FirstOrDefaultAsync(model => model.Name == Name);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await departmentDbContext.Employees.ToListAsync();
        }
    }
}
