using System.Runtime.Serialization;

namespace InterfaceSegregationPrinciple.Classes
{
    public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
	}
}
