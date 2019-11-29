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
    public class SesionxMascotasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SesionxMascotasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SesionxMascotas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SesionxMascota.Include(s => s.mascota).Include(s => s.sesion);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SesionxMascotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sesionxMascota = await _context.SesionxMascota
                .Include(s => s.mascota)
                .Include(s => s.sesion)
                .FirstOrDefaultAsync(m => m.idSesionxm == id);
            if (sesionxMascota == null)
            {
                return NotFound();
            }

            return View(sesionxMascota);
        }

        // GET: SesionxMascotas/Create
        public IActionResult Create()
        {
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota");
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion");
            return View();
        }

        // POST: SesionxMascotas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idSesionxm,idMascota,idSesion")] SesionxMascota sesionxMascota)
        {
            if (ModelState.IsValid)
            {
                //VERIFICAR QUE LA MASCOTA INGRESADA NO SEA LA MISMA
                //Busco el idMascota  y busco el idSesion
                bool duplicado = _context.SesionxMascota.Any(s => s.idMascota == sesionxMascota.idMascota && s.idSesion == sesionxMascota.idSesion);
                var sesion = _context.Sesion.Find(sesionxMascota.idSesion);
                var mascota = _context.Mascota.Where(m => m.idMascota == sesionxMascota.idMascota).Select(s => s.idRaza).First();
                var tipoRaza = _context.Raza.Where(r => r.idRaza == mascota).Select(s => s.idTipo).First();
                if (!duplicado)
                {
                    //Actualiza el tipo de raza de la sesion y agrega mascotas a la sesion                    
                    sesion.idTipo = tipoRaza;
                    _context.Update(sesion);
                    _context.Add(sesionxMascota);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details/" + sesionxMascota.idSesion, "Sesions");
                }
                else
                {
                    ModelState.AddModelError(string.Empty,"¡La mascota ingresada ya está en este Sesión!");
                    return View(sesion);
                }
                
            }
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota", sesionxMascota.idMascota);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", sesionxMascota.idSesion);
            return View(sesionxMascota);
        }

        // GET: SesionxMascotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sesionxMascota = await _context.SesionxMascota.FindAsync(id);
            if (sesionxMascota == null)
            {
                return NotFound();
            }
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota", sesionxMascota.idMascota);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", sesionxMascota.idSesion);
            return View(sesionxMascota);
        }

        // POST: SesionxMascotas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idSesionxm,idMascota,idSesion")] SesionxMascota sesionxMascota)
        {
            if (id != sesionxMascota.idSesionxm)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sesionxMascota);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SesionxMascotaExists(sesionxMascota.idSesionxm))
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
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "idMascota", sesionxMascota.idMascota);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", sesionxMascota.idSesion);
            return View(sesionxMascota);
        }

        // GET: SesionxMascotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sesionxMascota = await _context.SesionxMascota
                .Include(s => s.mascota)
                .Include(s => s.sesion)
                .FirstOrDefaultAsync(m => m.idSesionxm == id);
            if (sesionxMascota == null)
            {
                return NotFound();
            }

            return View(sesionxMascota);
        }

        // POST: SesionxMascotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sesionxMascota = await _context.SesionxMascota.FindAsync(id);
            _context.SesionxMascota.Remove(sesionxMascota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SesionxMascotaExists(int id)
        {
            return _context.SesionxMascota.Any(e => e.idSesionxm == id);
        }
    }
}
