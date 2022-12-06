using System.Linq;

namespace App1.Models
{
  public interface IRepository
  {
    IQueryable<Produto> Produtos { get; }
  }
}