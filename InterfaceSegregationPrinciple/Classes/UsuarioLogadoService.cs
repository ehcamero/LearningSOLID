using System.Runtime.Serialization;

namespace InterfaceSegregationPrinciple.Classes
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
