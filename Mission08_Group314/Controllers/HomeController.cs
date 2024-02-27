using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Group314.Models;
using System.Diagnostics;

namespace Mission08_Group314.Controllers
{
    public class HomeController : Controller
    {
        private IToDoRepository _repo;

        public HomeController(IToDoRepository temp)
        {
            _repo = temp;
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
                _repo.AddToDo(response);
            }
            else
            {
                return View(response);
            }
        }
    }
}
