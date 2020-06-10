using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tartarus_final.Models;

namespace Tartarus_final.Controllers
{
    public class PorukaController : Controller
    {
        private readonly NasContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public PorukaController(NasContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Poruka
        public async Task<IActionResult> Index()
        {
            ApplicationUser applicationUser = await _userManager.GetUserAsync(User);
            var poruke = from p in _context.Poruka select p;
            poruke = poruke.Where(p => p.PrimalacEmail.Equals(applicationUser.Email));
            return View(await poruke.ToListAsync());
        }

        // GET: Poruka/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poruka = await _context.Poruka
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poruka == null)
            {
                return NotFound();
            }

            return View(poruka);
        }

        // GET: Poruka/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Poruka/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tekst,PrimalacEmail,posiljalacEmail")] Poruka poruka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poruka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poruka);
        }

        // GET: Poruka/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poruka = await _context.Poruka.FindAsync(id);
            if (poruka == null)
            {
                return NotFound();
            }
            return View(poruka);
        }

        // POST: Poruka/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tekst,PrimalacEmail,posiljalacEmail")] Poruka poruka)
        {
            if (id != poruka.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poruka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PorukaExists(poruka.Id))
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
            return View(poruka);
        }

        // GET: Poruka/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poruka = await _context.Poruka
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poruka == null)
            {
                return NotFound();
            }

            return View(poruka);
        }

        // POST: Poruka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poruka = await _context.Poruka.FindAsync(id);
            _context.Poruka.Remove(poruka);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PorukaExists(int id)
        {
            return _context.Poruka.Any(e => e.Id == id);
        }
    }
}
