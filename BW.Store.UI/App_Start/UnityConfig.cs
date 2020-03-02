using BW.Store.Data.ADO.Repositories;
using BW.Store.Data.EF;
using BW.Store.Data.EF.Repositories;
using BW.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace BW.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<BWStoreDataContextEF>();
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoProdutoRepository, TipoProdutoRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryEF>();

            //container.RegisterType<IUsuarioRepository, UsuarioRepositoryADO>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}