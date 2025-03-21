namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura\n------------------\n\n");
            Console.WriteLine("Informe a temperatura em celsius");
            double tempC = double.Parse(Console.ReadLine());

            double tempF = tempC * 1.8 + 32;
            double tempK = tempC + 273.15;

            Console.WriteLine($"Temperatura em Fahrenheint : {tempF}\nTemperatura em Kelvin : {tempK}");
            Console.ReadLine();
        }
    }
}
