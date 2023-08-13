using System;
using System.Linq;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa palabra");
            char[] palabra = Console.ReadLine().ToCharArray();
            int totalCaracteres = palabra.Length;
            int totalVocales = 0;
            string palabraInvertida = string.Empty;
            int recorrido = totalCaracteres - 1;
            string[] vocales = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            foreach (char c in palabra)
            {
                totalVocales += vocales.Count(car => car == c.ToString());

                palabraInvertida += palabra[recorrido--];
            }

            Console.WriteLine($"totalCaracteres:'{totalCaracteres}' totalVocales:'{totalVocales}' palabraInvertida:'{palabraInvertida}'");
        }
    }
}
