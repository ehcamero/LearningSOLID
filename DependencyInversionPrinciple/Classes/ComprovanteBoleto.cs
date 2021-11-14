using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Classes
{
    public class ComprovanteBoleto : Comprovante
    {
        public double Desconto { get; set; }

        public ComprovanteBoleto(double desconto, string descricao, string valor, TipoPagamento tipoPagamento)
            : base(descricao, valor, tipoPagamento)
        {
            this.Desconto = desconto;
        }
    }
}
