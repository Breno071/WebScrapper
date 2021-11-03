using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using e_commerce.Models;
using HtmlAgilityPack;
using WebScrapper.Repository;

namespace WebScrapper
{
  class Program
  {
    static async Task Main(string[] args)
    {
      //https://chicorei.com/camiseta/masculino/
      Console.WriteLine("Digite uma URL Válida");
      var url = Console.ReadLine();
      if (string.IsNullOrEmpty(url) || !url.StartsWith("https"))
      {
        Console.WriteLine("URL Inválida");
        return;
      }
      HtmlWeb web = new HtmlWeb();
      var doc = web.Load(url);

      List<string> nomesProdutos = new List<string>();
      List<string> precoProdutos = new List<string>();
      List<string> imagensProdutos = new List<string>();


      Console.WriteLine("Scrapping...");

      //Pegando os nomes dos produtos
      foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//span[@class='Cell_Infos__3NFGH']//span//h2"))
      {
        nomesProdutos.Add(node.InnerText);
      }

      //Pegando os preços dos produtos
      foreach (var node in doc.DocumentNode.SelectNodes("//span[@class='CellPrice_Price__23YPv Cell_Price__3qsB6']//span//strong"))
      {

        precoProdutos.Add(node.InnerText);
      }

      //Pegando as imagens dos produtos
      foreach (var node in doc.DocumentNode.SelectNodes("//span[@class='Cell_Body__MIfCb']//span//div//img"))
      {

        var imagens = node.GetAttributeValue("src", "").Split(' ');
        foreach (var imagem in imagens)
        {

          if (imagem.Contains("https"))
          {
            imagensProdutos.Add(imagem);
          }
        }
      }

      for (int c = 0; c < imagensProdutos.Count; c++)
      {
        Roupa_Praia produto = new Roupa_Praia(nomesProdutos[c], precoProdutos[c], imagensProdutos[c]);
        await ProdutoRepository.CadastrarProduto(produto);
      }
      Console.WriteLine("Done.");
    }
  }
}

