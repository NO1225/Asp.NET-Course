using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TGWMI.Data.DataAccess;
using TGWMI.Data.Models;

namespace TGWMI.Controllers
{
    public class ContactTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ContactTypes
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactTypes.ToListAsync());
        }

        // GET: ContactTypes/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactType = await _context.ContactTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactType == null)
            {
                return NotFound();
            }

            return View(contactType);
        }

        // GET: ContactTypes/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContactTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeName")] ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactType);
        }

        // GET: ContactTypes/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactType = await _context.ContactTypes.FindAsync(id);
            if (contactType == null)
            {
                return NotFound();
            }
            return View(contactType);
        }

        // POST: ContactTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeName")] ContactType contactType)
        {
            if (id != contactType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactTypeExists(contactType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contactType);
        }

        // GET: ContactTypes/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactType = await _context.ContactTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactType == null)
            {
                return NotFound();
            }

            return View(contactType);
        }

        // POST: ContactTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactType = await _context.ContactTypes.FindAsync(id);
            _context.ContactTypes.Remove(contactType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactTypeExists(int id)
        {
            return _context.ContactTypes.Any(e => e.Id == id);
        }
    }
}
