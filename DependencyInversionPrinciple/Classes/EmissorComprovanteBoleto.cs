using DependencyInversionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Classes
{
    class EmissorComprovanteBoleto : IEmissorComprovante
    {
        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            ComprovanteBoleto comprovante = new ComprovanteBoleto(0.10, "Pagamento realizado", pagamentoRequest.Valor.ToString(), pagamentoRequest.TipoPagamento);

            comprovante.UsuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

            AplicarDesconto();

            Database.Save(comprovante);

            return comprovante;
        }

        private string AplicarDesconto()
        {
            return "Desconto aplicado";
        }
    }
}
