using System;

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números entre 1 e 500 ímpares e múltiplos de 3:\n");
            List<int> numbers = new List<int> { };
            for (int i = 1; i < 500; i++)
            {
                if ((i % 2 != 0 && i % 3 == 0) && !numbers.Contains(i))
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", numbers) + "\n");
        }
    }
}
