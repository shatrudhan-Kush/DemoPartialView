using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPartialView.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string  Job { get; set; }
        public bool Status { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Photo { get; set; }
    }
}