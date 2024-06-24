using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalTrabajo.Models;

namespace FinalTrabajo.Controllers
{
    public class DivisasController : Controller
    {
        private readonly Context _context;

        public DivisasController(Context context)
        {
            _context = context;
        }

        // GET: Divisas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Divisas.ToListAsync());
        }

        // GET: Divisas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisa = await _context.Divisas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (divisa == null)
            {
                return NotFound();
            }

            return View(divisa);
        }

        // GET: Divisas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Divisas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Codigo")] Divisa divisa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(divisa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(divisa);
        }

        // GET: Divisas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisa = await _context.Divisas.FindAsync(id);
            if (divisa == null)
            {
                return NotFound();
            }
            return View(divisa);
        }

        // POST: Divisas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Codigo")] Divisa divisa)
        {
            if (id != divisa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(divisa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DivisaExists(divisa.Id))
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
            return View(divisa);
        }

        // GET: Divisas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var divisa = await _context.Divisas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (divisa == null)
            {
                return NotFound();
            }

            return View(divisa);
        }

        // POST: Divisas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var divisa = await _context.Divisas.FindAsync(id);
            if (divisa != null)
            {
                _context.Divisas.Remove(divisa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DivisaExists(int id)
        {
            return _context.Divisas.Any(e => e.Id == id);
        }
    }
}
