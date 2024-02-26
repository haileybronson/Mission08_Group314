using Microsoft.AspNetCore.Mvc;
using Mission08_Group314.Models;
using System.Diagnostics;

namespace Mission08_Group314.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ToDo()
        {
            return View("ToDo");
        }

        [HttpPost]

        //"ToDo" is the class set up in the model 
        public IActionResult ToDo(ToDo response) 
        {
            return View("Confirmation", response);
        }
    }
}
