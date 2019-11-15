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
    public class ReservaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reserva
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reserva.Include(r => r.cliente).Include(r => r.servicio).Include(r => r.trabajador);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Reserva/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.servicio)
                .Include(r => r.trabajador)
                .FirstOrDefaultAsync(m => m.Reserva_ID == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reserva/Create
        public IActionResult Create()
        {
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "nombres");
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria");
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "nombres");
            return View();
        }

        // POST: Reserva/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Reserva_ID,fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador")] Reserva reserva)
        {
            reserva.fechaReservada = DateTime.Now;
            if (reserva.fechaSesion < reserva.fechaReservada)
            {
                ModelState.AddModelError("", "La fecha que usted ha ingresado es pasada, elija otra fecha");
            }
            else if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "nombres", reserva.idCliente);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria", reserva.idServicio);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "nombres", reserva.idTrabajador);
            return View(reserva);
        }

        // GET: Reserva/Edit/5
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
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "idTrabajador", reserva.idTrabajador);
            return View(reserva);
        }

        // POST: Reserva/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Reserva_ID,fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador")] Reserva reserva)
        {
            if (id != reserva.Reserva_ID)
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
                    if (!ReservaExists(reserva.Reserva_ID))
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
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "idTrabajador", reserva.idTrabajador);
            return View(reserva);
        }

        // GET: Reserva/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.servicio)
                .Include(r => r.trabajador)
                .FirstOrDefaultAsync(m => m.Reserva_ID == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reserva/Delete/5
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
            return _context.Reserva.Any(e => e.Reserva_ID == id);
        }
    }
}
