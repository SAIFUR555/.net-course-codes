using Microsoft.AspNetCore.Mvc;
using Mid_Lab_Task.Models;

namespace Mid_Lab_Task.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Profile(int id)
        {
            Student student = new Student
            {
                Id = id,
                Name = "Saif",
                Age = 21,
                Department = "CSE",
                CGPA = 3.85
            };

            return View(student);
        }
    }
}
