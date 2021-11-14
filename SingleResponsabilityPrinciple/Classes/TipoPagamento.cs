using System.Runtime.Serialization;

namespace SingleResponsabilityPrinciple.Classes
{
    public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
	}
}
