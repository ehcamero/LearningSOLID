using DependencyInversionPrinciple.Classes;
using Newtonsoft.Json;
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        // O construtor da classe RealizarPagamento recebe agora a interface IEmissorComprovante, dessa forma toda classe que extende essa interface pode ser utilizada como parametro para este
        // construtor.
        // Foi adicionado a parte de pagamento boleto
        static void Main(string[] args)
        {
            //RealizarPagamentoDebito();
            //RealizarPagamentoCredito();
            RealizarPagamentoBoleto();
        }

        public static void RealizarPagamentoBoleto()
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovanteBoleto());

            Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamentoBoleto());

            Console.WriteLine(JsonConvert.SerializeObject(comprovante));
        }

        public static void RealizarPagamentoCredito()
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovanteCredito());

            Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamentoCredito());

            Console.WriteLine(JsonConvert.SerializeObject(comprovante));
        }

        public static void RealizarPagamentoDebito()
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovanteDebito());

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

        private static PagamentoRequest CriarPagamentoBoleto()
        {
            return new PagamentoRequest(TipoPagamento.BOLETO, 100);
        }
    }
}
