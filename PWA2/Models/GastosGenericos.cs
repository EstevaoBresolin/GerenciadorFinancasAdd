//using PWA2.Controllers;

//namespace PWA2.Models
//{
//    public class GastosGenericos
//    {
//        HomeController controller;

//        public int Id { get; set; }
//        public string Nome { get; set; }
//        public double Valor { get; set; }
//        public DateTime Data { get; set; }
//        public int IDCategoria { get; set; }
//        public Categoria Categoria { get; set; }


//        public GastosGenericos(int id, string Nome, double Valor, string Categoria, DateTime Data, int IDCategoria)
//        {
//            this.Id = id;
//            this.Nome = Nome;
//            this.Valor = Valor;
//            this.IDCategoria = IDCategoria;
//            this.Data = Data;
//        }

//        public GastosGenericos()
//        {

//        }

//    }
//}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWA2.Models
{
    public class GastosGenericos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public double Valor { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [ForeignKey("Categoria")]
        public int IDCategoria { get; set; }

        public Categoria Categoria { get; set; }

        public GastosGenericos()
        {
        }

        public GastosGenericos(int id, string nome, double valor, int idCategoria, DateTime data)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            IDCategoria = idCategoria;
            Data = data;
        }
    }
}

