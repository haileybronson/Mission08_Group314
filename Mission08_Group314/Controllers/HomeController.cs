using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Group314.Models;
using System.Diagnostics;

namespace Mission08_Group314.Controllers
{
    public class HomeController : Controller
    {
        private ToDoFormContext _context;

        public IActionResult Index()
        {
            return View("ToDo");
        }

        public HomeController(ToDoFormContext temp)
        {
            _context = temp;
        }

        [HttpGet]
        public IActionResult ToDo()
        {
            return View("ToDo", new ToDo());
        }

        [HttpPost]

        //"ToDo" is the class set up in the model 
        public IActionResult ToDo(ToDo response) 
        {

            if (ModelState.IsValid)
            {
                _context.ToDo.Add(response); //adds record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }
        }
    }
}
