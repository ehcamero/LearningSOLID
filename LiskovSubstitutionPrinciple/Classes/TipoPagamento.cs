using System.Runtime.Serialization;

namespace LiskovSubstitutionPrinciple.Classes
{
    public enum TipoPagamento
	{
		[EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
	}
}
