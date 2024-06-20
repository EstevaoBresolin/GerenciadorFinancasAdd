using PWA2.Models;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public ICollection<GastosGenericos> GastosGenericos { get; set; } // Relacionamento com GastosGenericos
}
