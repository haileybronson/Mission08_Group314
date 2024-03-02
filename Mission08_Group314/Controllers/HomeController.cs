using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Group314.Models;
using SQLitePCL;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace Mission08_Group314.Controllers
{
    public class HomeController : Controller
    {
        private IToDoRepository _context;

        public HomeController(IToDoRepository temp)
        {
            _context = temp;
        }
        
        [HttpGet]
        public IActionResult ToDo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ToDo(ToDo response)
        {
            if (ModelState.IsValid)
            {
                _context.AddToDo(response);
                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }
        }

        public IActionResult Quadrants()
        {
            var Tasks = _context.ToDos.OrderBy(x => x.Task).ToList();

            return View(Tasks);
        }

        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var recordToEdit = _context.GetTaskId(id);
            return View("ToDo", recordToEdit);

        }

        [HttpPost]
        public IActionResult Edit(ToDo editedRecord)
        {
            _context.Update(editedRecord);

            return RedirectToAction("Quadrants");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.GetTaskId(id);
            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(ToDo deletedRecord)
        {
            _context.Delete(deletedRecord);
            return RedirectToAction("Quadrants");
        }



    }
}
