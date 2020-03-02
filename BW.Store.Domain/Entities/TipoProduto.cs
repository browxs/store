using System.Collections.Generic;

namespace BW.Store.Domain.Entities
{
    public class TipoProduto : Entity
    {
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
