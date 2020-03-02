using BW.Store.Domain.Contracts.Repositories;
using BW.Store.Domain.Entities;
using System.Linq;

namespace BW.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(BWStoreDataContextEF ctx) : base(ctx)
        {}

        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
