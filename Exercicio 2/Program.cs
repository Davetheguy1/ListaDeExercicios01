namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Volume de Cilindro\n-----------------\n");
            Console.WriteLine("Informe o Raio do Cilindo:\n");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Altura\n");
            double height = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius,2) * height;
            Console.WriteLine($"O Volume do Cilíndro é {volume} cm³.");

        }
    }
}
