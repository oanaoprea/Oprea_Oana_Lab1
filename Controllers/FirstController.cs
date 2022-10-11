using Microsoft.AspNetCore.Mvc;

namespace Oprea_Oana_Lab1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome, Oana!");
        }

        public IActionResult Salut()
        {
            return Content("Buna seara, Oana!");
        }

        public IActionResult Varsta(string nume, int varsta)
        {
            return Content(nume+" are varsta de "+varsta+" ani.");
        }
    }
}
