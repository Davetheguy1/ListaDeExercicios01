namespace Exercicio21
{
    internal class Program
    {
        
        
        static long FactorialGenerator(int cn)
        {
            long factorial = 1;
            for (int i = 1; i <= cn; i++)
            {
                factorial *= i;
            }
            
            return factorial;
            
        }
        
        static void mainProgram()
        {
            Console.WriteLine("Informe um Valor Inteiro de 1 a 20:\n");
            int chosenNum = int.Parse(Console.ReadLine());
            if (chosenNum > 20)
            {
                Console.WriteLine("Erro, Valor Muito Grande Escolhido.\n");
                mainProgram();
            }
            long factorial = FactorialGenerator(chosenNum);
            Console.WriteLine($"\nO Fatorial de {chosenNum} é: {factorial}");
            Environment.Exit(0);
        }
        
        static void Main(string[] args)
        {
            mainProgram();

        }
    }
}
