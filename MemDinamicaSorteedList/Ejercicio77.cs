using System;
using System.Collections.Generic;

namespace MemDinamicaSorteedList
{
    class Ejercicio77
    {
        static void Main() 
        {
            SortedList<string, string> diccio = new SortedList<string, string>();
            diccio.Add("Hi", "Hola");
            diccio.Add("How", "Cómo");
            diccio.Add("are you?", "estás?");
            string texto = "Hola,¿cómo estás?";
            string[] partes = texto.Split(',');

            foreach (string parte in partes)
            {
                Console.WriteLine(parte);
            }


            if (diccio.ContainsKey("adiós"))
                Console.WriteLine(diccio["adiós"]);

            Console.ReadKey();
        }
    }
}
