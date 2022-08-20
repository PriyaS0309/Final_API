using AFinal_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual Gender Gender { get; set; }

        [ForeignKey("Department_DepartmentID")]
        public virtual int Department_DepartmentID { get; set; }

        public virtual Department Department { get; set; }

    }
}
