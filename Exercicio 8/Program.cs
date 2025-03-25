using System.ComponentModel.Design;

namespace Exercicio_8
{
    internal class Program
    {
        
        static bool PrimeDetector(int num)
        {
            return false;
        }
        
        
        
        
        
        
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um Número Inteiro:\n");
            int num = int.Parse(Console.ReadLine());
            bool isPrime  = PrimeDetector(num);


            if  (isPrime == true)
            {
                Console.WriteLine($"\nO Número {num} é primo");
                Console.ReadLine();
            } else {
                Console.WriteLine($"\nO Número {num} não é primo");
            }
            
        }
    }
}
