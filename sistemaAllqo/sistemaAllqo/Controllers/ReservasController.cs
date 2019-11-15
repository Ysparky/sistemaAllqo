﻿using System;
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
            var applicationDbContext = _context.Reserva.Include(r => r.mascota).Include(r => r.servicio).Include(r => r.trabajador);
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
                .Include(r => r.mascota)
                .Include(r => r.servicio)
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
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "nombre");
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria");
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "nombres");
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idReserva,fechaReservada,fechaSesion,estado,idMascota,idServicio,idTrabajador")] Reserva reserva)
        {
            reserva.fechaReservada = DateTime.Now;
            if (reserva.fechaSesion < reserva.fechaReservada)
            {
                ModelState.AddModelError("","La fecha ingresada ha caducado, ingrese una fecha válida");
            }
            else if (ModelState.IsValid)
            {
                _context.Add(reserva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "nombre", reserva.idMascota);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria", reserva.idServicio);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "apellidos", reserva.idTrabajador);
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
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "nombre", reserva.idMascota);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria", reserva.idServicio);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "apellidos", reserva.idTrabajador);
            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idReserva,fechaReservada,fechaSesion,estado,idMascota,idServicio,idTrabajador")] Reserva reserva)
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
            ViewData["idMascota"] = new SelectList(_context.Mascota, "idMascota", "nombre", reserva.idMascota);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria", reserva.idServicio);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "apellidos", reserva.idTrabajador);
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
                .Include(r => r.mascota)
                .Include(r => r.servicio)
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
