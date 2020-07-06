using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TGWMI.Data.Models;
using TGWMI.Models;

namespace TGWMI.Controllers
{
    public class BooksController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult Index(BookViewModel model)
        {

            return View(model);
        }
    }
}
