using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Classes
{
    public class RealizarPagamento
	{
		private IEmissorComprovante _emissorComprovante;

        public RealizarPagamento(IEmissorComprovante emissorComprovante)
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
