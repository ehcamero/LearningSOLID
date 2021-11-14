using System.Runtime.Serialization;

namespace LiskovSubstitutionPrinciple.Classes
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
