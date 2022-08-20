using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_API.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public int Name { get; set; }
    }
}
