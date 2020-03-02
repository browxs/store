using BW.Store.Domain.Entities;

namespace BW.Store.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository:IRepository<Usuario>
    {
        Usuario Get(string email); 
    }
}
