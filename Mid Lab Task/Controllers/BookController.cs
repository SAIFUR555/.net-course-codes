using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Mid_Lab_Task.Models;


namespace Mid_Lab_Task.Controllers
{
    public class BookController : Controller
    {
        private List<Book> books = new List<Book>()
        {
            new Book{ Id=1, Title="C# Basics", Author="John", Category="Programming"},
            new Book{ Id=2, Title="ASP.NET Core", Author="David", Category="Programming"},
            new Book{ Id=3, Title="English Grammar", Author="Smith", Category="Language"}
        };

        public IActionResult List(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var filtered = books.Where(b => b.Category == id).ToList();
                return View(filtered);
            }

            return View(books);

        }
    }
}