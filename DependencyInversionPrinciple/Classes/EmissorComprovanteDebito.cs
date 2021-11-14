using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Classes
{
    class EmissorComprovanteDebito : IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            Comprovante comprovante = new Comprovante("Pagamento realizado", pagamentoRequest.Valor.ToString(), pagamentoRequest.TipoPagamento);

            comprovante.UsuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

            Database.Save(comprovante);

            return comprovante;
        }
    }
}
