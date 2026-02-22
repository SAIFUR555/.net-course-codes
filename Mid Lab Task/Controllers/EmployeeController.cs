using Microsoft.AspNetCore.Mvc;
using Mid_Lab_Task.Models;
using System.Collections.Generic;

namespace Mid_Lab_Task.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Name="Rahim", Salary=60000, Designation="Manager"},
                new Employee{ Name="Karim", Salary=45000, Designation="Developer"},
                new Employee{ Name="Hasan", Salary=70000, Designation="Manager"}
            };

            return View(employees);





        }
    }
}