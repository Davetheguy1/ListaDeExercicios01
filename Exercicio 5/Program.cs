namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // esqueci como que faz o calculo do salário


            Console.WriteLine("Calculadora de Salário\n-------------------------\n\n");
            Console.WriteLine("Salário Fixo(Base):");
            double baseSalary = double.Parse(Console.ReadLine());
            bool validNumber;
            Console.WriteLine("Comissão por Venda: \n(*O valor deve ser maior do que 0 e menor do que 1*)");
            double comission = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas Vendas feitas no mês:");
            double monthSalesNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor de cada venda:");
            double monthSalesValue = int.Parse(Console.ReadLine());
            double monthSales = monthSalesNum * monthSalesValue;
            

            double salary = baseSalary + (monthSales * comission);
            
            
            Console.WriteLine($"Seu Salário será {salary}");
            Console.ReadLine();
        }
    }
}
