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
    public class ReservaxMascotasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservaxMascotasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReservaxMascotas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ReservaxMascota.Include(r => r.mascota);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ReservaxMascotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservaxMascota = await _context.ReservaxMascota
                .Include(r => r.mascota)
                .FirstOrDefaultAsync(m => m.idReserva == id);
            if (reservaxMascota == null)
            {
                return NotFound();
            }

            return View(reservaxMascota);
        }

        // GET: ReservaxMascotas/Create
        public IActionResult Create()
        {
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota");
            return View();
        }

        // POST: ReservaxMascotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idReserva,idMascota")] ReservaxMascota reservaxMascota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservaxMascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota", reservaxMascota.idMascota);
            return View(reservaxMascota);
        }

        // GET: ReservaxMascotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservaxMascota = await _context.ReservaxMascota.FindAsync(id);
            if (reservaxMascota == null)
            {
                return NotFound();
            }
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota", reservaxMascota.idMascota);
            return View(reservaxMascota);
        }

        // POST: ReservaxMascotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idReserva,idMascota")] ReservaxMascota reservaxMascota)
        {
            if (id != reservaxMascota.idReserva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservaxMascota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaxMascotaExists(reservaxMascota.idReserva))
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
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota", reservaxMascota.idMascota);
            return View(reservaxMascota);
        }

        // GET: ReservaxMascotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservaxMascota = await _context.ReservaxMascota
                .Include(r => r.mascota)
                .FirstOrDefaultAsync(m => m.idReserva == id);
            if (reservaxMascota == null)
            {
                return NotFound();
            }

            return View(reservaxMascota);
        }

        // POST: ReservaxMascotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservaxMascota = await _context.ReservaxMascota.FindAsync(id);
            _context.ReservaxMascota.Remove(reservaxMascota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaxMascotaExists(int id)
        {
            return _context.ReservaxMascota.Any(e => e.idReserva == id);
        }
    }
}
