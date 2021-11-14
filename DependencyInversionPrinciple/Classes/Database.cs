using System;

namespace DependencyInversionPrinciple.Classes
{
    public class Database
	{
		public static void Save(object value)
		{
			Console.WriteLine("Recurso salvo");
		}
	}
}
