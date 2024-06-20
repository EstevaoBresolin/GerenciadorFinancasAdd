using Microsoft.EntityFrameworkCore;
using PWA2.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<GastosGenericos> GastosGenericos { get; set; }
    public DbSet<Orcamento> Orcamento { get; set; }

    public DbSet<Categoria> Categorias { get; set; }
}
