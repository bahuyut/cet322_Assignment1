using System;
using System.Collections.Generic;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Index()
        {
            return View(); 
        }

      
        [HttpPost]
        public IActionResult Index(Book book)
        {
            if (book == null)
            {
                
                return NotFound();
            }

            
            int remainingDays = (int)(book.DueDate - DateTime.Today).TotalDays;

            string color;
            if (remainingDays < 0)
                color = "red"; 
            else if (remainingDays < 3)
                color = "yellow"; 
            else
                color = "green"; 

            ViewBag.RemainingDaysColor = color;
            ViewBag.RemainingDays = remainingDays;

            return View(book);
        }
    }
}
