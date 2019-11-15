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
    public class LugarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LugarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Lugars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lugar.ToListAsync());
        }

        // GET: Lugars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lugar = await _context.Lugar
                .FirstOrDefaultAsync(m => m.idLugar == id);
            if (lugar == null)
            {
                return NotFound();
            }

            return View(lugar);
        }

        // GET: Lugars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lugars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idLugar,nombre,agregado")] Lugar lugar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lugar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lugar);
        }

        // GET: Lugars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lugar = await _context.Lugar.FindAsync(id);
            if (lugar == null)
            {
                return NotFound();
            }
            return View(lugar);
        }

        // POST: Lugars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idLugar,nombre,agregado")] Lugar lugar)
        {
            if (id != lugar.idLugar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lugar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LugarExists(lugar.idLugar))
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
            return View(lugar);
        }

        // GET: Lugars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lugar = await _context.Lugar
                .FirstOrDefaultAsync(m => m.idLugar == id);
            if (lugar == null)
            {
                return NotFound();
            }

            return View(lugar);
        }

        // POST: Lugars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lugar = await _context.Lugar.FindAsync(id);
            _context.Lugar.Remove(lugar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LugarExists(int id)
        {
            return _context.Lugar.Any(e => e.idLugar == id);
        }
    }
}
