using BW.Store.Domain.Entities;
using BW.Store.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace BW.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<BWStoreDataContextEF>
    {
        protected override void Seed(BWStoreDataContextEF context)
        {
            var alimento = new TipoProduto() { Nome = "Alimento" };
            var higiene = new TipoProduto() { Nome = "Higiene" };
            var eletronico = new TipoProduto() { Nome = "Eletrônico" };
            var limpeza = new TipoProduto() { Nome = "Limpeza" };

            var produtos = new List<Produto>() {
                new Produto() { Nome = "Picanha", Preco = 70.5M, Quantidade = 150, TipoProduto = alimento },
                new Produto() { Nome = "Iogurte", Preco = 10.5M, Quantidade = 250, TipoProduto = alimento },
                new Produto() { Nome = "Pasta de dente", Preco = 9.5M, Quantidade = 250, TipoProduto = higiene },
                new Produto() { Nome = "Sabonete", Preco = 5.5M, Quantidade = 1250, TipoProduto = higiene },
                new Produto() { Nome = "Desinfetante", Preco = 8.99M, Quantidade = 520, TipoProduto = limpeza },
                new Produto() { Nome = "Detergente", Preco = 4.49M, Quantidade = 1520, TipoProduto = limpeza },
                new Produto() { Nome = "Telefone", Preco = 125.15M, Quantidade = 85, TipoProduto = eletronico },
            };

            context.Produtos.AddRange(produtos);

            context.Usuarios.Add(new Usuario()
            {
                Nome = "Bruno Sousa",
                Email = "bruno@teste.com.br",
                Senha = "123".Encrypt()
            });

            context.SaveChanges();
        }
    }
}
