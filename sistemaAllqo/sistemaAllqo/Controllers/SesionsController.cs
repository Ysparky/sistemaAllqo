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
    public class SesionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SesionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sesions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sesion.Include(s => s.servicio).Include(s => s.tipoPerro).ToListAsync());
        }

        // GET: Sesions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sesion = await _context.Sesion
                .FirstOrDefaultAsync(m => m.idSesion == id);
            if (sesion == null)
            {
                return NotFound();
            }

            return View(sesion);
        }

        // GET: Sesions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sesions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idSesion,fechaSesion,lugar,tipoMascota,idServicio,numMascotas,estado")] Sesion sesion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sesion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sesion);
        }

        // GET: Sesions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sesion = await _context.Sesion.FindAsync(id);
            if (sesion == null)
            {
                return NotFound();
            }
            return View(sesion);
        }

        // POST: Sesions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idSesion,fechaSesion,lugar,tipoMascota,idServicio,numMascotas,estado")] Sesion sesion)
        {
            if (id != sesion.idSesion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sesion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SesionExists(sesion.idSesion))
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
            return View(sesion);
        }

        // GET: Sesions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sesion = await _context.Sesion
                .FirstOrDefaultAsync(m => m.idSesion == id);
            if (sesion == null)
            {
                return NotFound();
            }

            return View(sesion);
        }

        // POST: Sesions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sesion = await _context.Sesion.FindAsync(id);
            _context.Sesion.Remove(sesion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SesionExists(int id)
        {
            return _context.Sesion.Any(e => e.idSesion == id);
        }
    }
}
