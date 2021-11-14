using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabilityPrinciple.Classes
{
    public class EmissorComprovante
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
