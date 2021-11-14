using _S_ingle_Responsability_Principle.Classes;
using Newtonsoft.Json;
using System;

namespace _S_ingle_Responsability_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento();

            Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamento());

            Console.WriteLine(JsonConvert.SerializeObject(comprovante));
        }

        private static PagamentoRequest CriarPagamento()
        {
            return new PagamentoRequest(TipoPagamento.CREDITO, 30.0);
        }
    }
}
