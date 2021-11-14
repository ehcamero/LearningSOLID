namespace OpenClosePrinciple.Classes
{
    public class RealizarPagamento
	{
		private EmissorComprovante _emissorComprovante;

        public RealizarPagamento(EmissorComprovante emissorComprovante)
        {
			this._emissorComprovante = emissorComprovante;
        }

		public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
		{
			Comprovante comprovante = _emissorComprovante.emitir(pagamento);

			return comprovante;
		}
	}
}
