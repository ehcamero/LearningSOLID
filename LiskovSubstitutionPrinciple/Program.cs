using LiskovSubstitutionPrinciple.Classes;
using Newtonsoft.Json;
using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        // Adicionado IF para verificar o tipo de pagamento na classe EmissorComprovante
        // O fato da variável comprovante aceitar um tipo ComprovanteCredito e um tipo Comprovante, é a demonstração final do conceito LiskovSubstitutionPrinciple
        // Foi criado um novo construtor na classe PagamentoRequest, para suportar somente o tipo débito
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
