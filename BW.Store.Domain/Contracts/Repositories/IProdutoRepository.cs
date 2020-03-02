using BW.Store.Domain.Entities;
using System.Collections.Generic;

namespace BW.Store.Domain.Contracts.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetByNameContains(string contains);
    }
}
