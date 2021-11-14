using Newtonsoft.Json;
using SingleResponsabilityPrinciple.Classes;
using System;

namespace SingleResponsabilityPrinciple
{
    class Program
    {
        // O método emitir da classe EmissorComprovante foi removido de dentro da classe RealizarPagamento
        // Foi feito uma injeção de depedência na classe RealizarPagamento
        static void Main(string[] args)
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovante());

            Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamento());

            Console.WriteLine(JsonConvert.SerializeObject(comprovante));
        }

        private static PagamentoRequest CriarPagamento()
        {
            return new PagamentoRequest(TipoPagamento.CREDITO, 30.0);
        }
    }
}
