using System;
using Humanizer;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Humanizando Números!");
            int numero = 321651321;
            string numeroPorExtenso = numero.ToWords();
            Console.WriteLine($"{numero} --> {numeroPorExtenso}");

        }
    }
}
