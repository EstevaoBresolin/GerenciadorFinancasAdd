
namespace PWA2.Models
{
    public class Db
    {
        private readonly MyDbContext _context;

        public Db(MyDbContext context)
        {
            _context = context;
        }

        // Adicionar categorias
        public bool AdicionarGasto(GastosGenericos gasto)
        {
            _context.GastosGenericos.Add(gasto);
            _context.SaveChanges();
            return true;
        }

        // Obter categorias
        public List<GastosGenericos> ObterGastosPorCategoria(string categoria)
        {
            return _context.GastosGenericos.Where(g => g.Categoria == categoria).ToList();
        }

        // Obter todos os gastos
        public List<GastosGenericos> ObterTodosGastos()
        {
            return _context.GastosGenericos.ToList();
        }

        // Obter gasto por ID
        public GastosGenericos ObterGastoPorId(int id)
        {
            return _context.GastosGenericos.Find(id);
        }

        // Excluir gasto
        public string ExcluirGasto(int id)
        {
            var gasto = _context.GastosGenericos.Find(id);
            if (gasto != null)
            {
                _context.GastosGenericos.Remove(gasto);
                _context.SaveChanges();
                return $"Gasto {id} foi removido com sucesso";
            }
            return $"Gasto {id} não encontrado";
        }

        // Editar gasto
        public void EditarGasto(GastosGenericos gasto)
        {
            _context.GastosGenericos.Update(gasto);
            _context.SaveChanges();
        }
    }
}
