using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _S_ingle_Responsability_Principle.Classes
{
    public class EmissorComprovante
    {
        //Função retorna um comprovante
        public Comprovante EmitirComprovante(double valor, TipoPagamento tipoPagamento)
        {
            Comprovante comprovante = new Comprovante("Pagamento realizado", valor.ToString(), tipoPagamento);
            try
            {
                //usuarioLogado recebe a informação da classe estática usuário, que está mockado
                string usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();

                //Valida se a string não está vazia
                if (!string.IsNullOrEmpty(usuarioLogado))
                {
                    //Aplica o valor da string usuarioLogado no atributo da classe comprovante "UsuarioLogado"
                    comprovante.UsuarioLogado = usuarioLogado;
                    //Salva no banco mockado
                    Database.Save(comprovante);
                }
                //throw new Exception("Usuário não logado");
            } catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return comprovante;
        }
    }
}
