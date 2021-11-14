using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _S_ingle_Responsability_Principle.Classes
{
    public class Comprovante
    {
        //Construtor comprovante
        public Comprovante(string descricao, string valor, TipoPagamento tipoPagamento)
        {
            this.Descricao = descricao;
            this.Valor = valor;
            this.TipoPagamento = tipoPagamento;
        }

        public string Descricao { get; set; }
        public string Valor { get; set; }
        //Newtonsoft nuget, converte um enum para uma string que será salva no json
        [JsonConverter(typeof(StringEnumConverter))]
        public TipoPagamento TipoPagamento { get; set; }
        public string UsuarioLogado { get; set; }
    }
}
