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
    public class ReservasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reservas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reserva.Include(r => r.cliente).Include(r => r.servicio).Include(r => r.sesion).Include(r => r.trabajador);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.servicio)
                .Include(r => r.sesion)
                .Include(r => r.trabajador)
                .FirstOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reservas/Create
        public IActionResult Create()
        {
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "idCliente");
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "idServicio");
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion");
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "idTrabajador");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idReserva,fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador,idSesion")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "idCliente", reserva.idCliente);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "idServicio", reserva.idServicio);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", reserva.idSesion);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "idTrabajador", reserva.idTrabajador);
            return View(reserva);
        }

        // GET: Reservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "idCliente", reserva.idCliente);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "idServicio", reserva.idServicio);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", reserva.idSesion);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "idTrabajador", reserva.idTrabajador);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idReserva,fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador,idSesion")] Reserva reserva)
        {
            if (id != reserva.idReserva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.idReserva))
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
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "idCliente", reserva.idCliente);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "idServicio", reserva.idServicio);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", reserva.idSesion);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "idTrabajador", reserva.idTrabajador);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.servicio)
                .Include(r => r.sesion)
                .Include(r => r.trabajador)
                .FirstOrDefaultAsync(m => m.idReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reserva.FindAsync(id);
            _context.Reserva.Remove(reserva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reserva.Any(e => e.idReserva == id);
        }
    }
}
