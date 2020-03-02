using BW.Store.Domain.Contracts.Repositories;
using BW.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BW.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(BWStoreDataContextEF ctx) : base(ctx)
        {}

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(contains));
        }
    }
}
