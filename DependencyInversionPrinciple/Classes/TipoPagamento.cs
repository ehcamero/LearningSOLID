using System.Runtime.Serialization;

namespace DependencyInversionPrinciple.Classes
{
    public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO,
		[EnumMember(Value = "Credito")]
		BOLETO
	}
}
