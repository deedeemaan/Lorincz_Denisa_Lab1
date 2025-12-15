using Lorincz_Denisa_Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lorincz_Denisa_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }

        public IActionResult Mesaj()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;

            return View();
        }

    }
}
