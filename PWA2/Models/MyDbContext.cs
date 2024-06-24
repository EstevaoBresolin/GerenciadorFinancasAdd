//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Migrations;
//using PWA2.Models;
//using GerenciadorFinancas.Models;

//public class MyDbContext : DbContext
//{
//    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

//    public DbSet<GastosGenericos> GastosGenericos { get; set; }
//    public DbSet<Orcamento> Orcamento { get; set; }

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PWA2.Models;
using GerenciadorFinancas.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Security.Principal;
using System;

public class MyDbContext : IdentityDbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    public DbSet<GastosGenericos> GastosGenericos { get; set; }
    public DbSet<Orcamento> Orcamento { get; set; }

    //    Criando as páginas de Identidade
    //Adicione as páginas de Identidade ao seu projeto.No console do Gerenciador de Pacotes NuGet, execute o seguinte comando:

    //powershell
    //    Copiar código
    //    dotnet aspnet-codegenerator identity -dc MyDbContext
    //3. Atualizando o Banco de Dados
    //Após ajustar as classes e configurar o Identity, você precisará atualizar o banco de dados para refletir essas mudanças.No console do Gerenciador de Pacotes NuGet, execute os seguintes comandos:

    //powershell
    //Copiar código
    //Add-Migration AddIdentity
    //Update-Database
}


    //public DbSet<Categoria> Categorias { get; set; }

    //
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<GastosGenericos>()
    //        .HasOne(g => g.Categoria)
    //        .WithMany()
    //        .HasForeignKey(g => g.IDCategoria);
    //}

    //// View
    //public DbSet<GastosComCategoria> VwGastosComCategorias { get; set; }

    // ADICIONAR AO BANCO
    //    CREATE VIEW dbo.VwGastosComCategorias
    //  AS
    //  SELECT
    //    g.Id,
    //    g.Nome,
    //    g.Valor,
    //    g.Data,
    //    c.Nome AS CategoriaNome
    //  FROM
    //    GastosGenericos g
    //  INNER JOIN
    //    Categorias c ON g.CategoriaId = c.Id;

    /////////// COLAR ISSO NO BANCO ////////////
    //INSERT INTO Categorias(Nome) VALUES('Outros');
    //INSERT INTO Categorias(Nome) VALUES('Educacao');
    //INSERT INTO Categorias(Nome) VALUES('Casa');
    //INSERT INTO Categorias(Nome) VALUES('Saude');
    //INSERT INTO Categorias(Nome) VALUES('Lazer');
    //INSERT INTO Categorias(Nome) VALUES('Transporte');
    //INSERT INTO Categorias(Nome) VALUES('Alimentacao');
    //INSERT INTO Categorias(Nome) VALUES('Investimentos');

    //  POR ULTIMO COLAR ISSO

    //Add-Migration UpdateGastosGenericos
    //Update-Database


}
