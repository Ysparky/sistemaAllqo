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
            ViewData["adiestramientos"] = _context.Set<Reserva>().Where(e => e.idServicio == 1).ToList();
            ViewData["paseos"] = _context.Set<Reserva>().Where(e => e.idServicio == 2).ToList();
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
            ViewData["idCliente"] = new SelectList(_context.Cliente.Where(e=>e.mascotas.Count != 0), "idCliente", "apellidos");
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria");
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion");
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "apellidos");

            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idReserva,fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador,idSesion")] Reserva reserva)
        {
            reserva.fechaReservada = DateTime.Now;
            if (ModelState.IsValid)
            {
                int clienteFinded = _context.Cliente.Where(c => c.idCliente == reserva.idCliente).Select(c => c.idLugar).First();
                string nombreLugarFinded = _context.Lugar.Where(l => l.idLugar == clienteFinded).Select(l => l.nombre).First();
                //int servicioFinded = _context.Servicio.Where(s => s.idServicio == reserva.idServicio).Select(s => s.idServicio).First();
                //Busca en las sesiones si hay lugares 
                DateTime fechaSesionFinded = reserva.fechaSesion;
                int idSesionFinded = _context.Sesion.Include(s=>s.reservas).Where(s => s.lugar == nombreLugarFinded && s.fechaSesion == fechaSesionFinded && s.idServicio == reserva.idServicio).Select(s => s.idSesion).FirstOrDefault();

                if (idSesionFinded != 0)
                {
                    reserva.idSesion = idSesionFinded;
                    _context.Add(reserva);
                    _context.SaveChanges();
                }
                else if (idSesionFinded.Equals(0))
                {
                    Sesion newSesion = new Sesion();
                    newSesion.fechaSesion = reserva.fechaSesion;
                    newSesion.lugar = nombreLugarFinded;
                    newSesion.idServicio = reserva.idServicio;
                    //newSesion.servicio = 
                    _context.Add(newSesion);
                    _context.SaveChanges();
                    reserva.idSesion = newSesion.idSesion;
                    _context.Add(reserva);
                    _context.SaveChanges();
                }        
                

                SesionxMascota sesionxMascota = new SesionxMascota();
                sesionxMascota.idSesion = reserva.idSesion;
                _context.Add(sesionxMascota);
                ViewData["idMascota"] = new SelectList(_context.Mascota.Where(e => e.idCliente == reserva.idCliente), "idMascota", "nombre");
                return View("AddsPetsToSesion", sesionxMascota);

                //sesionxMascota.idSesion = reserva.idSesion;
                //_context.Add(sesionxMascota);
                //ViewData["idMascota"] = new SelectList(_context.Mascota.Where(e=>e.idCliente == reserva.idCliente), "idMascota", "nombre");
                //return View("AddsPetsToSesion", sesionxMascota);
            }
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "apellidos", reserva.idCliente);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria", reserva.idServicio);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", reserva.idSesion);
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
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "apellidos", reserva.idCliente);
            ViewData["idServicio"] = new SelectList(_context.Servicio, "idServicio", "categoria", reserva.idServicio);
            ViewData["idSesion"] = new SelectList(_context.Sesion, "idSesion", "idSesion", reserva.idSesion);
            ViewData["idTrabajador"] = new SelectList(_context.Trabajador, "idTrabajador", "apellidos", reserva.idTrabajador);
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
