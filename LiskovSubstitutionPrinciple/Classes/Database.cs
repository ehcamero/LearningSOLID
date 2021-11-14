using System;

namespace LiskovSubstitutionPrinciple.Classes
{
    public class Database
	{
		public static void Save(object value)
		{
			Console.WriteLine("Recurso salvo");
		}
	}
}
