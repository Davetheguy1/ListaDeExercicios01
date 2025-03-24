using System;

namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Impares entre 100 e 200:\n");
            
            List<int> numbers = new List<int> { };
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);

                }
                
            }

            Console.WriteLine(string.Join(", ", numbers) + "\n");
        }
    }
}
