using System.Runtime.ConstrainedExecution;

namespace Exercicio10
{
    internal class Program
    {

        /*A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
        pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
        venda dos pães e broas(juntos), e quanto deve guardar numa conta de poupança(10% do total arrecadado).
        Você foi contratado para fazer os cálculos para o dono.Com base nestes fatos, faça um algoritmo para ler as
        quantidades de pães e de broas, e depois calcular os dados solicitados.*/


        static double doSalesTotal(double f, double b) {
            double fSalesTotal = f * 0.12;
            double bSalesTotal = b * 1.50;

            double total = fSalesTotal + bSalesTotal;

            return total;

        }        


        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de Pães Franceses Vendidos:");
            double fBreadSales = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de Broas Vendidos:");
            double bBreadSales = double.Parse(Console.ReadLine());

            double total = doSalesTotal(fBreadSales, bBreadSales);
            double invest = total * 0.10;
            double roundedInvest = Math.Round(invest,2);

            Console.WriteLine($"Total de Vendas: R${total}.\nTotal a Investir: R${roundedInvest}.");
            Console.WriteLine("\nPressione Enter pra Fechar a Aplicação.");
            Console.ReadLine();
        }
    }
}
