using System;

namespace _S_ingle_Responsability_Principle.Classes
{
    //Mockando classe database para simular um banco de dados com um retorno
    public class Database
    {
        public static void Save(object value)
        {
            Console.WriteLine("Recurso Salvo");
        }
    }
}
