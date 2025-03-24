namespace Exercicio23
{
    internal class Program
    { /*Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
       múltiplos de 3 pela palavra &quot;Fizz&quot; e os múltiplos de 5 pela palavra &quot;Buzz&quot;. Para números que são múltiplos de
       ambos, use &quot;FizzBuzz.*/

        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { };
            for(int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0 && !numbers.Contains(i))
                {
                    numbers.Add(i);
                    Console.WriteLine("FizzBuzz, ");
                }

                if (i % 3 == 0 && !numbers.Contains(i))
                {
                    numbers.Add(i);
                    Console.WriteLine("Fizz, ");
                }

                if (i % 5 == 0 && !numbers.Contains(i))
                {
                    numbers.Add(i);
                    Console.WriteLine("Buzz, ");
                }

                if (i < 100 && !numbers.Contains(i))
                {
                    numbers.Add(i);
                    Console.WriteLine($"{i}, ");
                }

            }
            Console.WriteLine("\n\n");
            Console.WriteLine(string.Join(", ", numbers) + "\n");
        }
    }
}
