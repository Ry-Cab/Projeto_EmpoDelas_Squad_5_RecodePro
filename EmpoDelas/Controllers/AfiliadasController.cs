using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpoDelas.Data;
using empodelas.Models;

namespace EmpoDelas.Controllers
{
    public class AfiliadasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AfiliadasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Afiliadas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Afiliada.ToListAsync());
        }

        // GET: Afiliadas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliada = await _context.Afiliada
                .FirstOrDefaultAsync(m => m.Id_afiliada == id);
            if (afiliada == null)
            {
                return NotFound();
            }

            return View(afiliada);
        }

        // GET: Afiliadas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Afiliadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_afiliada,Nome_afiliada,Sobrenome_afiliada,Email_afiliada,DataNasc_afiliada,NumTelefone_afiliada,Endereco_afiliada,Cep_afiliada,Descricao_afiliada,ComprovanteResid_afiliada")] Afiliada afiliada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(afiliada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(afiliada);
        }

        // GET: Afiliadas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliada = await _context.Afiliada.FindAsync(id);
            if (afiliada == null)
            {
                return NotFound();
            }
            return View(afiliada);
        }

        // POST: Afiliadas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_afiliada,Nome_afiliada,Sobrenome_afiliada,Email_afiliada,DataNasc_afiliada,NumTelefone_afiliada,Endereco_afiliada,Cep_afiliada,Descricao_afiliada,ComprovanteResid_afiliada")] Afiliada afiliada)
        {
            if (id != afiliada.Id_afiliada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afiliada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfiliadaExists(afiliada.Id_afiliada))
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
            return View(afiliada);
        }

        // GET: Afiliadas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliada = await _context.Afiliada
                .FirstOrDefaultAsync(m => m.Id_afiliada == id);
            if (afiliada == null)
            {
                return NotFound();
            }

            return View(afiliada);
        }

        // POST: Afiliadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var afiliada = await _context.Afiliada.FindAsync(id);
            _context.Afiliada.Remove(afiliada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AfiliadaExists(int id)
        {
            return _context.Afiliada.Any(e => e.Id_afiliada == id);
        }
    }
}
