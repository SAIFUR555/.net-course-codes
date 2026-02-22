using Microsoft.AspNetCore.Mvc;
using Mid_Lab_Task.Models;


namespace Mid_Lab_Task.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1200m, Category = "Electronics" },
                new Product { Id = 2, Name = "Mouse", Price = 500m, Category = "Accessories" }
            };

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = new Product { Id = id, Name = "Laptop", Price = 1200m, Category = "Electronics" };
            return View(product);
        }
    }
}
