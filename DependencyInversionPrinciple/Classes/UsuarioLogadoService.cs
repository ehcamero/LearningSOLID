using System.Runtime.Serialization;

namespace DependencyInversionPrinciple.Classes
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
