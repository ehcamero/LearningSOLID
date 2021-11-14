
using Newtonsoft.Json;
using OpenClosePrinciple.Classes;
using System;

namespace OpenClosePrinciple
{
    class Program
    {
        // Classe ComprovanteCredito foi criada, extendendo de Comprovante e adicionando a propriedade "Parcelas". Também foi criado o construtor com base, retornando os dados para o pai
        // Na classe PagamentoRequest também foi adicionado a propriedade "Parcelas" e adicionado ao construtor
        static void Main(string[] args)
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovante());
                
            Comprovante comprovante = realizarPagamento.RegistrarPagamento(CriarPagamento());

            Console.WriteLine(JsonConvert.SerializeObject(comprovante));
        }

        private static PagamentoRequest CriarPagamento()
        {
            // Este problema será solucionado com Liskov Substitution Principle
            return new PagamentoRequest(TipoPagamento.CREDITO, 30.0);
        }
    }
}
