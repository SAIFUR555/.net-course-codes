using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bio()
            {
                return View();
        }
        public IActionResult Projects()
            {
                return View();
            }



        public IActionResult Skills()
            {
                return View();
        }

        
    }
}
