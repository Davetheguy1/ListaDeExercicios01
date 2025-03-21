namespace Exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medidas de Terreno\n-------------------\n\n");
            Console.WriteLine("Comprimento do Terreno:\n");
            double comp = double.Parse(Console.ReadLine());
            Console.WriteLine("Largura do Terreno:\n");
            double larg = double.Parse(Console.ReadLine());

            double result = comp * larg;
            Console.WriteLine($"Área do Terreno: {result} m²");
        }
    }
}
