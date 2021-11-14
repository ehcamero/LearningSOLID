using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace InterfaceSegregationPrinciple.Classes
{
    public class Comprovante
	{
		public Comprovante(string descricao, string valor, TipoPagamento tipoPagamento)
		{
			this.Descricao = descricao;
			this.Valor = valor;
			this.TipoPagamento = tipoPagamento;
		}

		public string Descricao { get; set; }

		public string Valor { get; set; }

		[JsonConverter(typeof(StringEnumConverter))]
		public TipoPagamento TipoPagamento { get; set; }

        public string UsuarioLogado { get; set; }
    }
}
