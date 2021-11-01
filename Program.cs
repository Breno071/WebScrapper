using System.Xml.Linq;
using System;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace WebScrapper
{
  class Program
  {
    static void Main(string[] args)
    {
      var url = "https://www.zoom.com.br/notebook";
      HtmlWeb web = new HtmlWeb();
      var doc = web.Load(url);

      List<string> nomesProdutos = new List<string>();
      List<string> precoProdutos = new List<string>();
      List<string> imagensProdutos = new List<string>();

      foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//h2[@class='Text_Text___RzD- Text_LabelSmRegular__2Lr6I']"))
      {

        Console.WriteLine(node.InnerText);
        nomesProdutos.Add(node.InnerText);
      }

      foreach (var node in doc.DocumentNode.SelectNodes("//strong[@class='Text_Text___RzD- Text_LabelMdBold__3KBIj CellPrice_MainValue__3s0iP']"))
      {

        Console.WriteLine(node.InnerText);
        precoProdutos.Add(node.InnerText);
      }
      foreach (var node in doc.DocumentNode.SelectNodes("//span[@class='Cell_ImageContainer__2-Uda']//img"))
      {

        var imagens = node.GetAttributeValue("src", "").Split(' ');
        foreach (var imagem in imagens)
        {
          //Console.WriteLine(imagem);
          if (imagem.Contains("https"))
          {
            imagensProdutos.Add(imagem);
          }
        }

      }
      foreach (var imagem in imagensProdutos)
      {
        Console.WriteLine(imagem);
      }

    }
  }
}

