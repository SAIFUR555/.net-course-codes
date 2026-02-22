using Microsoft.AspNetCore.Mvc;
using Mid_Lab_Task.Models;
using System.Collections.Generic;
using System.Linq;
 
namespace Mid_Lab_Task.Controllers
{
    public class CourseController : Controller
    {
        private List<Course> courses = new List<Course>()
        {
            new Course{ Id=1, Title="Math", Credit=3, Semester=1},
            new Course{ Id=2, Title="OOP", Credit=3, Semester=2},
            new Course{ Id=3, Title="Database", Credit=3, Semester=2}
        };

        public IActionResult List(int? semester)
        {
            if (semester.HasValue)
            {
                var filtered = courses.Where(c => c.Semester == semester.Value).ToList();
                return View(filtered);
            }

            return View(courses);
        }
    }
}
