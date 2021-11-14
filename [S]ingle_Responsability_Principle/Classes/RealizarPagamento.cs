using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _S_ingle_Responsability_Principle.Classes
{
    public class RealizarPagamento
    {
        //Se vi realizar o pagamento, precisa emitir um comprovante
        public EmissorComprovante emissorComprovante = new EmissorComprovante();

        //Método para registrar o pagamento, as informações chegam do pagamentoRequest (valor, parcelas e tipo de pagamento)
        public Comprovante RegistrarPagamento(PagamentoRequest pagamento)
        {
            Comprovante comprovante = emissorComprovante.EmitirComprovante(pagamento.Valor, pagamento.TipoPagamento);

            return comprovante;
        }
    }
}
