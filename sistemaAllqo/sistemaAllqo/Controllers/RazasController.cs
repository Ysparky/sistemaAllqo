using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sistemaAllqo.Data;
using sistemaAllqo.Models;

namespace sistemaAllqo.Controllers
{
    public class RazasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RazasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Razas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Raza.Include(r => r.tipoperro);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Razas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raza = await _context.Raza
                .Include(r => r.tipoperro)
                .FirstOrDefaultAsync(m => m.idRaza == id);
            if (raza == null)
            {
                return NotFound();
            }

            return View(raza);
        }

        // GET: Razas/Create
        public IActionResult Create()
        {
            ViewData["idTipo"] = new SelectList(_context.tipoPerro, "idTipo", "idTipo");
            return View();
        }

        // POST: Razas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idRaza,nombre,idTipo")] Raza raza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(raza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idTipo"] = new SelectList(_context.tipoPerro, "idTipo", "idTipo", raza.idTipo);
            return View(raza);
        }

        // GET: Razas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raza = await _context.Raza.FindAsync(id);
            if (raza == null)
            {
                return NotFound();
            }
            ViewData["idTipo"] = new SelectList(_context.tipoPerro, "idTipo", "idTipo", raza.idTipo);
            return View(raza);
        }

        // POST: Razas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idRaza,nombre,idTipo")] Raza raza)
        {
            if (id != raza.idRaza)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(raza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RazaExists(raza.idRaza))
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
            ViewData["idTipo"] = new SelectList(_context.tipoPerro, "idTipo", "idTipo", raza.idTipo);
            return View(raza);
        }

        // GET: Razas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var raza = await _context.Raza
                .Include(r => r.tipoperro)
                .FirstOrDefaultAsync(m => m.idRaza == id);
            if (raza == null)
            {
                return NotFound();
            }

            return View(raza);
        }

        // POST: Razas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var raza = await _context.Raza.FindAsync(id);
            _context.Raza.Remove(raza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RazaExists(int id)
        {
            return _context.Raza.Any(e => e.idRaza == id);
        }
    }
}
