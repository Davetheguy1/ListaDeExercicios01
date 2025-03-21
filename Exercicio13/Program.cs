namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um Valor A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um Valor B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um Valor C:");
            int C = int.Parse(Console.ReadLine());

            int sum = A + B;
            Console.WriteLine("Soma de A e B: " + sum);
            bool isSmallerThanC;
            if (A + B < C)
            {
                isSmallerThanC = true;
            } else
            {
                isSmallerThanC = false;
            }
            string boolFinal;
            if (isSmallerThanC == true)
            {
                boolFinal = "Sim";
            } else
            {
                boolFinal = "Não";
            }

            Console.WriteLine($"A Soma é Maior que C?: {boolFinal}");
        }
    }
}
