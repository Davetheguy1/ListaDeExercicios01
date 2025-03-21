namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu Salário:\n");
            double salary = double.Parse(Console.ReadLine());

            double salaryPlus = salary + (salary * 0.15);
            double salaryFinal = salaryPlus - (salaryPlus * 0.08);

            Console.WriteLine($"Seu Salário Incial: R${salary}\nSeu Salário Após o Aumento: R${salaryPlus}\nSeu Salário Final Após Impostos: R${salaryFinal}");

        }
    }
}
