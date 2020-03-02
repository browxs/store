using BW.Store.Domain.Contracts.Repositories;
using BW.Store.Domain.Entities;

namespace BW.Store.Data.EF.Repositories
{
    public class TipoProdutoRepositoryEF : RepositoryEF<TipoProduto>, ITipoProdutoRepository
    {
        public TipoProdutoRepositoryEF(BWStoreDataContextEF ctx) : base(ctx)
        {}
    }
}
