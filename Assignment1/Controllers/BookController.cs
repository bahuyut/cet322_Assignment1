using System;
using System.Collections.Generic;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Index(string Name, string Author, int PageNumber, DateTime DueDate)
        {
            Book kitap = new Book();
            kitap.Name = Name;
            kitap.Author = Author;
            kitap.PageNumber = PageNumber;
            kitap.DueDate = DueDate;
            return View(kitap); 
        }


      
       
    }
}
