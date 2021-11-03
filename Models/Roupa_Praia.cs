using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
  public class Roupa_Praia

  {
    [Key]
    public int id { get; set; }

    public string nome { get; set; }
    public string preco { get; set; }
    public string imagem { get; set; }

    public int quantidade { get; set; }

    public Roupa_Praia(string nome, string preco, string imagem)
    {
      this.nome = nome;
      this.preco = preco;
      this.imagem = imagem;
      this.quantidade = 1;
    }
  }
}