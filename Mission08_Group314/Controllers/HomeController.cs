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
    }
}
