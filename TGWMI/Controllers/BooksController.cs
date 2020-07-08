using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TGWMI.Data.DataAccess;
using TGWMI.Data.Models;
using TGWMI.Models;

namespace TGWMI.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _context
                .Students
                .Include(s => s.StudentSubjects)
                .ThenInclude(ss => ss.Subject)
                .Select(student => new StudentViewModel()
                {
                    FullName = student.FullName,
                    Id = student.Id,
                    Subjects = student
                        .StudentSubjects
                        .Select(studentSubject => new SubjectViewModel() { Name = studentSubject.Subject.Name })
                        .ToList()
                })
                .ToListAsync();

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(BookViewModel model)
        {

            return View(model);
        }
    }
}
