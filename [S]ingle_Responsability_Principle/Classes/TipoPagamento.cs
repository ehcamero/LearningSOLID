using System.Runtime.Serialization;

namespace _S_ingle_Responsability_Principle.Classes
{
    public enum TipoPagamento
    {
        //EnumMember é utilizado para serialização para json.
        //Enum funciona como uma "lista" e seus elementos estão em um array, logo, "DEBITO" = 0 / "CREDITO" = 1 etc...
        [EnumMember(Value = "Debito")]
        DEBITO,
        [EnumMember(Value = "Credito")]
        CREDITO,
        [EnumMember(Value = "Boleto")]
        BOLETO
    }
}
