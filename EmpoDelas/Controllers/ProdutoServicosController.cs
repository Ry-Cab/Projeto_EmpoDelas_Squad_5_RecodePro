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
    public class ProdutoServicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutoServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProdutoServicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoServico.ToListAsync());
        }
        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _context.ProdutoServico.ToListAsync());
        }

        // GET: ProdutoServicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoServico = await _context.ProdutoServico
                .FirstOrDefaultAsync(m => m.Id_produtoServico == id);
            if (produtoServico == null)
            {
                return NotFound();
            }

            return View(produtoServico);
        }

        // GET: ProdutoServicos/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult ImagemAnexar()
        {
            return View();
        }

        // POST: ProdutoServicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_produtoServico,Codigo_produtoServico,Tipo_produtoServico,Nome_produtoServico,Descricao_produtoServico,Imagem_produtoServico,Preco_produtoServico,NomeNegocio_autonoma,FK_id_autonoma")] ProdutoServico produtoServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoServico);
                await _context.SaveChangesAsync();
                return RedirectToAction("ImagemAnexar");
            }
            return View(produtoServico);
        }

        // GET: ProdutoServicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoServico = await _context.ProdutoServico.FindAsync(id);
            if (produtoServico == null)
            {
                return NotFound();
            }
            return View(produtoServico);
        }

        // POST: ProdutoServicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_produtoServico,Codigo_produtoServico,Tipo_produtoServico,Nome_produtoServico,Descricao_produtoServico,Imagem_produtoServico,Preco_produtoServico,NomeNegocio_autonoma,FK_id_autonoma")] ProdutoServico produtoServico)
        {
            if (id != produtoServico.Id_produtoServico)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoServicoExists(produtoServico.Id_produtoServico))
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
            return View(produtoServico);
        }

        // GET: ProdutoServicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoServico = await _context.ProdutoServico
                .FirstOrDefaultAsync(m => m.Id_produtoServico == id);
            if (produtoServico == null)
            {
                return NotFound();
            }

            return View(produtoServico);
        }

        // POST: ProdutoServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoServico = await _context.ProdutoServico.FindAsync(id);
            _context.ProdutoServico.Remove(produtoServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoServicoExists(int id)
        {
            return _context.ProdutoServico.Any(e => e.Id_produtoServico == id);
        }
    }
}
