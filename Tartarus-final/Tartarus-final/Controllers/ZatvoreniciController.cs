using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tartarus_final.Models;

namespace Tartarus_final.Controllers
{
    public class ZatvoreniciController : Controller
    {
        private readonly NasContext _context;

        public ZatvoreniciController(NasContext context)
        {
            _context = context;
        }

        // GET: Zatvorenici
        public async Task<IActionResult> Index(string searchString)
        {
            var zatvorenici = from p in _context.Zatvorenik select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                zatvorenici = zatvorenici.Where(p => p.Ime.Contains(searchString));
            }
            return View(await zatvorenici.ToListAsync());
        }

        // GET: Zatvorenici/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zatvorenik = await _context.Zatvorenik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zatvorenik == null)
            {
                return NotFound();
            }

            return View(zatvorenik);
        }

        // GET: Zatvorenici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zatvorenici/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZatvorskaKazna,Evaluacija,Jmbg,Id,Ime,Prezime")] Zatvorenik zatvorenik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zatvorenik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zatvorenik);
        }

        // GET: Zatvorenici/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zatvorenik = await _context.Zatvorenik.FindAsync(id);
            if (zatvorenik == null)
            {
                return NotFound();
            }
            return View(zatvorenik);
        }

        // POST: Zatvorenici/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZatvorskaKazna,Evaluacija,Jmbg,Id,Ime,Prezime")] Zatvorenik zatvorenik)
        {
            if (id != zatvorenik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zatvorenik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZatvorenikExists(zatvorenik.Id))
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
            return View(zatvorenik);
        }

        // GET: Zatvorenici/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zatvorenik = await _context.Zatvorenik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zatvorenik == null)
            {
                return NotFound();
            }

            return View(zatvorenik);
        }

        // POST: Zatvorenici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zatvorenik = await _context.Zatvorenik.FindAsync(id);
            _context.Zatvorenik.Remove(zatvorenik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZatvorenikExists(int id)
        {
            return _context.Zatvorenik.Any(e => e.Id == id);
        }
    }
}
