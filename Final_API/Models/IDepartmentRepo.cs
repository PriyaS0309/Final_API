using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public interface IDepartmentRepo
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);

    }
}
