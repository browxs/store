using BW.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BW.Store.Data.EF.Maps
{
    public class ProdutoMap:EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable(nameof(Produto));

            HasKey(pk => pk.Id);
            
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(c => c.Preco).HasColumnType("money");
            Property(c => c.Quantidade);
            Property(c => c.TipoProdutoId);
            Property(c => c.DataCadastro);

            HasRequired(p => p.TipoProduto).WithMany(t => t.Produtos).HasForeignKey(fk => fk.TipoProdutoId);
        }
    }
}
