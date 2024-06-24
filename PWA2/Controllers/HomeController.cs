using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWA2.Models;
using System.Collections.Generic;
using System.Linq;

namespace PWA2.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    

        public IActionResult Index()
        {
            var gastosGenericos = _context.GastosGenericos.ToList();

            ViewBag.Total = GastoTotal(gastosGenericos);
            ViewBag.Saldo = Saldo();
            ViewBag.Outros = _context.GastosGenericos.Where(g => g.Categoria == "Outros").Sum(g => g.Valor);
            ViewBag.Educacao = _context.GastosGenericos.Where(g => g.Categoria == "Educacao").Sum(g => g.Valor);
            ViewBag.Casa = _context.GastosGenericos.Where(g => g.Categoria == "Casa").Sum(g => g.Valor);
            ViewBag.Saude = _context.GastosGenericos.Where(g => g.Categoria == "Saude").Sum(g => g.Valor);
            ViewBag.Lazer = _context.GastosGenericos.Where(g => g.Categoria == "Lazer").Sum(g => g.Valor);
            ViewBag.Transporte = _context.GastosGenericos.Where(g => g.Categoria == "Transporte").Sum(g => g.Valor);
            ViewBag.Alimentacao = _context.GastosGenericos.Where(g => g.Categoria == "Alimentacao").Sum(g => g.Valor);
            ViewBag.Investimentos = _context.GastosGenericos.Where(g => g.Categoria == "Investimentos").Sum(g => g.Valor);
            ViewBag.Orcamento = _context.Orcamento.FirstOrDefault()?.Valor ?? 0;

            Dictionary<string, double> totalPorCategoria = new Dictionary<string, double>();

            foreach (var gasto in gastosGenericos)
            {
                if (totalPorCategoria.ContainsKey(gasto.Categoria))
                {
                    totalPorCategoria[gasto.Categoria] += gasto.Valor;
                }
                else
                {
                    totalPorCategoria[gasto.Categoria] = gasto.Valor;
                }
            }

            ViewBag.Categoria = totalPorCategoria;
            return View(gastosGenericos);
        }

        //////////// OBTER VALORES //////////////////  
        public double Saldo()
        {
            double orcamento = _context.Orcamento.FirstOrDefault()?.Valor ?? 0;
            double total = _context.GastosGenericos.Sum(x => x.Valor);
            return orcamento - total;
        }

        public double GastoTotal(List<GastosGenericos> gastos)
        {
            return gastos.Sum(x => x.Valor);
        }

        

        public IActionResult AdicionarGasto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarGasto(GastosGenericos gastosGenericos)
        {
            if (ModelState.IsValid)
            {
                _context.GastosGenericos.Add(gastosGenericos);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gastosGenericos);
        }

        [HttpPost]
        public IActionResult AdicionarOrcamento(double _orcamento)
        {
            var orcamento = _context.Orcamento.FirstOrDefault();
            if (orcamento != null)
            {
                orcamento.Valor = _orcamento;
                _context.Orcamento.Update(orcamento);
            }
            else
            {
                _context.Orcamento.Add(new Orcamento { Valor = _orcamento });
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var gastos = _context.GastosGenericos
                             .Include(g => g.Categoria)
                             .FirstOrDefault(g => g.Id == id);

            if (gastos == null)
            {
                return NotFound();
            }

            return View(gastos);
        }

        [HttpPost]
        public IActionResult Editar(GastosGenericos gastosGenericos)
        {
            if (ModelState.IsValid)
            {
                _context.GastosGenericos.Update(gastosGenericos);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }


            return View(gastosGenericos);
        }

      
        public IActionResult Excluir(int id)
        {
            var gasto = _context.GastosGenericos.Find(id);
            if (gasto == null)
            {
                return NotFound();
            }
            _context.GastosGenericos.Remove(gasto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
