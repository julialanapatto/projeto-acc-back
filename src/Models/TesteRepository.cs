using System.Linq;

namespace App1.Models
{
  public class TesteRepository : IRepository
  {
    private static Produto[] Dados = new Produto[] {
      new Produto { ProdutoId=1, Nome="Caneta", Categoria="Papelaria", Preco=1.00m },
      new Produto { ProdutoId=2, Nome="Borracha", Categoria="Papelaria", Preco=2.00m },
      new Produto { ProdutoId=3, Nome="Caderno", Categoria="Papelaria", Preco=3.00m },
      new Produto { ProdutoId=4, Nome="Tablet", Categoria="Eletrônicos", Preco=4.00m },
      new Produto { ProdutoId=5, Nome="Iphone", Categoria="Eletrônicos", Preco=5.00m },
    };

    public IQueryable<Produto> Produtos => Dados.AsQueryable();
  }
}