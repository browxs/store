using BW.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BW.Store.Data.EF.Maps
{
    public class TipoProdutoMap:EntityTypeConfiguration<TipoProduto>
    {
        public TipoProdutoMap()
        {
            ToTable(nameof(TipoProduto));

            HasKey(pk => pk.Id);

            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nome).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(c => c.DataCadastro);
        }
    }
}
