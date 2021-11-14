using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Classes
{
    class EmissorComprovanteCredito : IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            ComprovanteCredito comprovante = new ComprovanteCredito(pagamentoRequest.Parcelas, "Pagamento realizado", pagamentoRequest.Valor.ToString(), pagamentoRequest.TipoPagamento);

            comprovante.UsuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

            VerificarLimite();

            Database.Save(comprovante);

            return comprovante;
        }

        private string VerificarLimite()
        {
            return "Sem limite";
        }
    }
}
