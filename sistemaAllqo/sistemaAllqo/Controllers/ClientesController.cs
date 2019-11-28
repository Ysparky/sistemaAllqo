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
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cliente.Include(c => c.lugar);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.lugar)
                .FirstOrDefaultAsync(m => m.idCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            List<Mascota> mascotas = _context.Set<Mascota>().Where(item => item.idCliente == id).Include(e => e.raza).ToList();
            ViewData["Mascotas"] = mascotas;
            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewData["idRaza"] = new SelectList(_context.Raza, "idRaza", "idRaza");
            ViewData["idLugar"] = new SelectList(_context.Lugar, "idLugar", "nombre");
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idCliente,nombres,apellidos,direccion,dni,correo,numCelular,estado,idLugar")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                Mascota mascota = new Mascota();
                int idCliente = cliente.idCliente;
                mascota.idCliente = idCliente;
                //mascota.idRaza = 1;
                _context.Add(mascota);
                ViewData["idRaza"] = new SelectList(_context.Raza, "idRaza", "nombre");
                return View("Pet", mascota);
            }
            ViewData["idLugar"] = new SelectList(_context.Lugar, "idLugar", "nombre", cliente.lugar.nombre);
            return View();
        }
        public async Task<IActionResult> Pet(int? id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            Mascota mascota = new Mascota();
            mascota.idCliente = cliente.idCliente;
            ViewData["idRaza"] = new SelectList(_context.Raza, "idRaza", "nombre");
            return View(mascota);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pet([Bind("idMascota,nombre,edad,idCliente,idRaza")] Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mascota);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Details));
            }
            ViewData["idCliente"] = new SelectList(_context.Cliente, "idCliente", "idCliente", mascota.idCliente);
            ViewData["idRaza"] = new SelectList(_context.Raza, "idRaza", "idRaza", mascota.idRaza);
            return View(mascota);
        }
        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["idLugar"] = new SelectList(_context.Lugar, "idLugar", "nombre", cliente.idLugar);
            return View(cliente);
        }
        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idCliente,nombres,apellidos,direccion,dni,correo,numCelular,estado,idLugar")] Cliente cliente)
        {
            if (id != cliente.idCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.idCliente))
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
            ViewData["idLugar"] = new SelectList(_context.Lugar, "idLugar", "nombre", cliente.idLugar);
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(c => c.lugar)
                .FirstOrDefaultAsync(m => m.idCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool MascotaExists(int id)
        {
            return _context.Mascota.Any(e => e.idMascota == id);
        }
        private bool ClienteExists(int id)
        {
            return _context.Cliente.Any(e => e.idCliente == id);
        }
    }
}
