using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Classes
{
    public class EmissorComprovante
    {
		Comprovante comprovante = null;
		public Comprovante emitir(PagamentoRequest pagamentoRequest)
		{
            if (pagamentoRequest.TipoPagamento.Equals(TipoPagamento.CREDITO))
            {
				comprovante = new ComprovanteCredito(10, "Pagamento realizado", pagamentoRequest.Valor.ToString(), pagamentoRequest.TipoPagamento);
            }
            else
            {
				comprovante = new Comprovante("Pagamento realizado", pagamentoRequest.Valor.ToString(), pagamentoRequest.TipoPagamento);
			}
			
			comprovante.UsuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

			Database.Save(comprovante);

			return comprovante;
		}
	}
}
