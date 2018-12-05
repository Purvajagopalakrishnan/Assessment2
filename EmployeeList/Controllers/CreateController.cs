using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeList.Controllers
{
    public class CreateController : Controller
    {
        List<Employee> emp = new List<Employee>()
        {
            new Employee {Emp_Id = 101,Emp_Name = "Rahul", Manager_Id = 103},
            new Employee {Emp_Id = 102,Emp_Name = "Priya", Manager_Id = 103},
            new Employee {Emp_Id = 103,Emp_Name = "Sowmiya"},
            new Employee {Emp_Id = 104,Emp_Name = "Divya", Manager_Id = 105},
            new Employee {Emp_Id = 105,Emp_Name = "Jim"},
            new Employee {Emp_Id = 106,Emp_Name = "John", Manager_Id = 103},

        };
        public IActionResult Index()
        {
   
            return View(emp);
        }

        public IActionResult Edit(int Id)
        {
            var emp1 = emp.Where(s => s.Manager_Id == Id).FirstOrDefault();
            return View(emp1);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp1)
        {
           
            var id = emp1.Manager_Id;

            return RedirectToAction("Index");
        }

      public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete()
        {
             try
             {  
                 return RedirectToAction("Index");
             }
             catch
             {
                 return View();
             }
            
        }
    }
}