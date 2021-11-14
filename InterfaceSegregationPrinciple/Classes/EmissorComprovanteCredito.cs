using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Classes
{
    class EmissorComprovanteCredito : IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            Comprovante comprovante = new ComprovanteCredito(10, "Pagamento realizado", pagamentoRequest.Valor.ToString(), pagamentoRequest.TipoPagamento);

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
