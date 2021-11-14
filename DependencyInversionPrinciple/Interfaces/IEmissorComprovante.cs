using DependencyInversionPrinciple.Classes;

namespace DependencyInversionPrinciple.Interfaces
{
    public interface IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest);
    }
}
