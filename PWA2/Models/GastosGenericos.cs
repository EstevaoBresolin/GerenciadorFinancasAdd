using PWA2.Controllers;

namespace PWA2.Models
{
    public class GastosGenericos
    {
        HomeController controller;

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public int IDCategoria { get; set; }
        public Categoria Categoria { get; set; }


        public GastosGenericos(int id, string Nome, double Valor, string Categoria, DateTime Data, int IDCategoria)
        {
            this.Id = id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.IDCategoria = IDCategoria;
            this.Data = Data;
        }

        public GastosGenericos()
        {
          
        }

    }
}
