namespace Exercicio20
{
    internal class Program
    {
        
        static void MainProgram()
        {
            Console.WriteLine("Escreva um número de 1 a 10:\n");
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 10)
            {
                Console.WriteLine("Erro, Informe um valor entre 1 e 10.\n");
                MainProgram();
            }
            for (int i=1; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} X {i} = {result}\n");
            }
            Enquire();
        }
        
        static void Enquire()
        {
            Console.WriteLine("Tabuda Finalizada, deseja fazer outra tabuada? (y/n)");
            string response = Console.ReadLine();
            if (response == "y")
            {
                MainProgram();
            }
            else if (response == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Erro, Valor inválido Informado, tente novamente.\n");
                Enquire();
            }
        }



        static void Main(string[] args)
        {
            MainProgram();
        }
        
    }
}
