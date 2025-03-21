namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Comprimento da caixa");
            double comp = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Largura da caixa");
            double larg = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite Altura da caixa");
            double alt = double.Parse(Console.ReadLine());

            double result = comp * larg * alt;
            double resultInLiters = result / 1000;
            Console.WriteLine($"O volume da caixa é {result} cm³ ({resultInLiters} L)");
            Console.ReadLine();

        }
    }
}
