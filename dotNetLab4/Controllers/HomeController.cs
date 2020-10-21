using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotNetLab4.Models;


namespace dotNetLab4.Controllers
{
    public class HomeController : Controller
    {
        NoteBookContext db;
        public HomeController(NoteBookContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.NoteBook.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.noteBookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Thank You, " + order.User;
        }
    }
}
