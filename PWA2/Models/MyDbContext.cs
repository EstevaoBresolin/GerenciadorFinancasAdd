﻿using GerenciadorFinancas.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PWA2.Models;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    public DbSet<GastosGenericos> GastosGenericos { get; set; }
    public DbSet<Orcamento> Orcamento { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    // View
    public DbSet<GastosComCategoria> VwGastosComCategorias { get; set; }

    // ADICIONAR AO BANCO
    //    CREATE VIEW dbo.VwGastosComCategorias
    //AS
    //SELECT
    //    g.Id,
    //    g.Nome,
    //    g.Valor,
    //    g.Data,
    //    c.Nome AS CategoriaNome
    //FROM
    //    GastosGenericos g
    //INNER JOIN
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

}
