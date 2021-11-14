using System.Runtime.Serialization;

namespace SingleResponsabilityPrinciple.Classes
{
    [DataContract]
	class UsuarioLogadoService
	{
		public static string GetUsuarioLogado()
		{
			return "solid@gmail.com";
		}
	}
}
