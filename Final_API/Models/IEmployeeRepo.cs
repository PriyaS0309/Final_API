using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public interface IEmployeeRepo
    {
            Task<IEnumerable<Employee>> GetEmployees();
            Task<Employee> GetEmployee(int ID);
            Task<Employee> GetEmployeeByName(string Name);
            Task<Employee> AddEmployee(Employee employee);
            Task<Employee> EditEmployee(Employee employee);

           Task<Employee> DeleteEmployee(int id);

    }
}
