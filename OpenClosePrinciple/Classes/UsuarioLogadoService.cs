using System.Runtime.Serialization;

namespace OpenClosePrinciple.Classes
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
