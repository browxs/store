namespace BW.Store.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public short Quantidade { get; set; }
        public int TipoProdutoId { get; set; }
        public virtual TipoProduto TipoProduto { get; set; }
    }
}
