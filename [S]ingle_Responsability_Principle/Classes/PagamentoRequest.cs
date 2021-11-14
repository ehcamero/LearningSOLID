namespace _S_ingle_Responsability_Principle.Classes
{
    public class PagamentoRequest
    {
        // Construtor PagamentoRequest
        public PagamentoRequest(TipoPagamento tipoPagamento, double valor)
        {
            this.Valor = valor;
        }

        public double Valor { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public int QuantidadeParcelas { get; set; }
    }
}
