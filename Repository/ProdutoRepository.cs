using System.Threading.Tasks;
using e_commerce.Models;

namespace WebScrapper.Repository
{
  public static class ProdutoRepository
  {
    public static async Task CadastrarProduto(Roupa_Praia produto)
    {
      using (var context = new Context())
      {
        context.Roupas_Praia.Add(produto);
        await context.SaveChangesAsync();
      }
    }
  }
}