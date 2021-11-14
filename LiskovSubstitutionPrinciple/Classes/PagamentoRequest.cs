namespace LiskovSubstitutionPrinciple.Classes
{
    public class PagamentoRequest
	{
		public double Valor { get; set; }

		public TipoPagamento TipoPagamento { get; set; }

        public int Parcelas { get; set; }

        public PagamentoRequest(TipoPagamento tipoPagamento, double valor, int parcelas)
		{
			this.TipoPagamento = tipoPagamento;
			this.Valor = valor;
			this.Parcelas = parcelas;
		}

		public PagamentoRequest(TipoPagamento tipoPagamento, double valor)
		{
			this.TipoPagamento = tipoPagamento;
			this.Valor = valor;
		}
	}
}
