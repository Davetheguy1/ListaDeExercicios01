using System.Numerics;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cosumo de Combustivél por KM percorrido\n------------------");
            Console.WriteLine("Informe o KM Inicial");
            double KmI = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o KM Final");
            double KmII = double.Parse(Console.ReadLine());
            Console.WriteLine("Quanos Litros de Gasolina foram usados?");
            double consp = double.Parse(Console.ReadLine());

            double totalDistance = KmII - KmI;
            double consumption = totalDistance / consp;

            Console.WriteLine($"O consumo médio foi de {consumption} Km/L");
        }
    }
}
