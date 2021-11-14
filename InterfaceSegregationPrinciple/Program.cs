using InterfaceSegregationPrinciple.Classes;
using Newtonsoft.Json;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        // A classe EmissorComprovante foi descontinuada, pois agora foi necessário criar uma classe para emitir comprovante de débito e outro para emitir comprovante de crédito
        // pois o processo de crédito precisa checar se o usuário tem limite e a classe de débito não precisa executar essa ação. Porém a classe EmissorComprovante faria essa validação
        // utilizando "if", deixando a sua responsabilidade muito grande, ferindo assim o primeiro princípio.
        // Classe EmissorComprovanteDebito e EmissorComprovanteCredito foram adicionadas, ambos implementando a interface IEmissorComprovante
        // Método "VerificarSaldo" foi implementado dentro da classe EmissorComprovanteCredito
        static void Main(string[] args)
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovante());

            Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamentoDebito());

            Console.WriteLine(JsonConvert.SerializeObject(comprovante));
        }

        private static PagamentoRequest CriarPagamentoCredito()
        {
            return new PagamentoRequest(TipoPagamento.CREDITO, 30.0, 10);
        }

        private static PagamentoRequest CriarPagamentoDebito()
        {
            return new PagamentoRequest(TipoPagamento.DEBITO, 30.0);
        }
    }
}
