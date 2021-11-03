using e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace WebScrapper
{
  public class Context : DbContext
  {
    string DbPath = @"D:\Narde\VS Code\Projects\.NET projects\e-commerce\Db\";
    public DbSet<Camisa> Camisas { get; set; }
    public DbSet<Notebook> Notebooks { get; set; }
    public DbSet<Celular> Celulares { get; set; }
    public DbSet<Item_Cozinha> Itens_Cozinha { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Roupa_Praia> Roupas_Praia { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Data Source={this.DbPath}produtos.db");
    }
  }
}