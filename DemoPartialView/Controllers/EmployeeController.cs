using DemoPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPartialView.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ViewResult DisplayDetails()
        {
            Employee emp1 = new Employee { Id = 1001, Name = "Rani", Job = "maneger", Salary = 50000.00, City = "Delhi", Photo = "/Images/lahga1.png", Status = true };
            Employee emp2 = new Employee { Id = 1002, Name = "Arti", Job = "HR", Salary = 60000.00, City = "Delhi", Photo = "/Images/lahga2j.jpg", Status = true };
            Employee emp3= new Employee { Id = 1003, Name = "Pooja", Job = "Developer", Salary = 70000.00, City = "Mumbai", Photo ="Images/lahga4p.png", Status = true };
            Employee emp4 = emp3;
            List<Employee> list = new List<Employee> { emp1,emp2,emp3, emp4 };
            return View(list);
        }
    }
}