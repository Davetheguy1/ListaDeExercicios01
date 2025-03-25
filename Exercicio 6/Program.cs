namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite a primera nota:");
            int g1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            int g2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            int g3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota:");
            int g4 = int.Parse(Console.ReadLine());

            decimal harmonicAverage = 4 * (1 / g1) + (1 / g2) + (1 / g3) + (1 / g4);

            Console.WriteLine($"A Média Harmonica é {harmonicAverage}");
        }
    }
}
