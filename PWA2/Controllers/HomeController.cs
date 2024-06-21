using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWA2.Models;
using System.Collections.Generic;
using System.Linq;

namespace PWA2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult ListaGastos()
        {
            var gastosComCategoria = _context.VwGastosComCategorias.ToList();
            return View(gastosComCategoria);
        }

        public IActionResult Index()
        {
            var gastosGenericos = _context.GastosGenericos
                .Include(g => g.Categoria) 
                .ToList();

            ViewBag.Total = GastoTotal(gastosGenericos);
            ViewBag.Saldo = Saldo();
            ViewBag.Orcamento = _context.Orcamento.FirstOrDefault()?.Valor ?? 0;

          



            //ViewBag.Outros = _context.GastosGenericos.Where(g => g.Categoria == "Outros").Sum(g => g.Valor);
            //ViewBag.Educacao = _context.GastosGenericos.Where(g => g.Categoria == "Educacao").Sum(g => g.Valor);
            //ViewBag.Casa = _context.GastosGenericos.Where(g => g.Categoria == "Casa").Sum(g => g.Valor);
            //ViewBag.Saude = _context.GastosGenericos.Where(g => g.Categoria == "Saude").Sum(g => g.Valor);
            //ViewBag.Lazer = _context.GastosGenericos.Where(g => g.Categoria == "Lazer").Sum(g => g.Valor);
            //ViewBag.Transporte = _context.GastosGenericos.Where(g => g.Categoria == "Transporte").Sum(g => g.Valor);
            //ViewBag.Alimentacao = _context.GastosGenericos.Where(g => g.Categoria == "Alimentacao").Sum(g => g.Valor);
            //ViewBag.Investimentos = _context.GastosGenericos.Where(g => g.Categoria == "Investimentos").Sum(g => g.Valor);

            var totalPorCategoria = gastosGenericos
               .GroupBy(g => g.Categoria.Nome)
               .Select(group => new { Categoria = group.Key, Total = group.Sum(g => g.Valor) })
               .ToDictionary(g => g.Categoria, g => g.Total);

            ViewBag.Categoria = totalPorCategoria;

            //Dictionary<string, double> totalPorCategoria = new Dictionary<string, double>();

            //foreach (var gasto in gastosGenericos)
            //{
            //    if (totalPorCategoria.ContainsKey(gasto.Categoria))
            //    {
            //        totalPorCategoria[gasto.Categoria] += gasto.Valor;
            //    }
            //    else
            //    {
            //        totalPorCategoria[gasto.Categoria] = gasto.Valor;
            //    }
            //}

            //ViewBag.Categoria = totalPorCategoria;
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

        //////////// Adicionar Gastos ///////////////
        //public IActionResult AdicionarGasto()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AdicionarGasto(GastosGenericos _gastosGenericos)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.GastosGenericos.Add(_gastosGenericos);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(_gastosGenericos);
        //}

        public IActionResult AdicionarGasto()
        {
            ViewBag.Categorias = _context.Categorias.ToList();
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
            ViewBag.Categorias = _context.Categorias.ToList();
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

        //////////// Editar gasto ///////////////        
        //public IActionResult Editar(int id)
        //{
        //    var gastos = _context.GastosGenericos.Find(id);
        //    if (gastos == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewBag.Categorias = _context.Categorias.ToList();
        //    return View(gastos);
        //}

        public IActionResult Editar(int id)
        {
            var gastos = _context.GastosGenericos
                             .Include(g => g.Categoria) // Certifique-se de incluir a categoria
                             .FirstOrDefault(g => g.Id == id);

            if (gastos == null)
            {
                return NotFound();
            }

            ViewBag.Categorias = _context.Categorias.ToList(); // Carrega todas as categorias disponíveis

            return View(gastos);
        }

        [HttpPost]
        public IActionResult Editar(GastosGenericos gastosGenericos)
        {
            if (ModelState.IsValid)
            {
                // Atualiza o estado do objeto GastosGenericos e salva no banco de dados
                _context.GastosGenericos.Update(gastosGenericos);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Categorias = _context.Categorias.ToList(); // Carrega todas as categorias disponíveis

            return View(gastosGenericos);
        }

        //[HttpPost]
        //public IActionResult Editar(GastosGenericos gastosGenericos)
        //{
        //    //_context.GastosGenericos.Update(gastosGenericos);
        //    //_context.SaveChanges();
        //    //return RedirectToAction("Index");

        //    if (ModelState.IsValid)
        //    {
        //        _context.GastosGenericos.Update(gastosGenericos);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Categorias = _context.Categorias.ToList();
        //    return View(gastosGenericos);
        //}


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
