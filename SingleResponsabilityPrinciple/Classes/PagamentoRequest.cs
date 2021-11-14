namespace SingleResponsabilityPrinciple.Classes
{
    public class PagamentoRequest
	{
		public double Valor { get; set; }

		public TipoPagamento TipoPagamento { get; set; }

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor)
		{
			this.Valor = valor;
		}
	}
}
