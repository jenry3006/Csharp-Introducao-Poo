using System;

namespace Csharp.Introdução.Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hello Word
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();
            #endregion

            #region Char e Strings

            char letra = 'B';
            string frase = "om dia!";

            Console.WriteLine(letra + frase);
            Console.WriteLine(string.Concat(letra, frase));
            Console.WriteLine($"{letra}{frase} Jenry");
            Console.WriteLine(string.Format("{0}{1} Jenry", letra, frase));
            Console.WriteLine(frase[6]);
            Console.WriteLine($"Informe seu nome: {Console.ReadLine() }");

            Console.ReadKey();

            #endregion
        }
    }
}
