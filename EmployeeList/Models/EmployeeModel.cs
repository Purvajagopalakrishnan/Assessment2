using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeList.Models
{
    public class EmployeeModel
    {
        public List<Employee> Employees { get; set; }
        public int Edit { get; set; }
        public int Delete { get; set; }
    }
}
