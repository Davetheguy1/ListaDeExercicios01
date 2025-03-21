using System;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Notas\n---------------\n\n");
            Console.WriteLine("Declare a nota da Primeira Prova");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o peso da Primeira Prova");
            double p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare a nota da Segunda Prova");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare o peso da Segunda Prova");
            double p2 = double.Parse(Console.ReadLine());

            double average = ((n1 * p1) + (n2 * p2)) / (p1 + p2);

            Console.WriteLine($"Média : {average}");
        }
    }
}
