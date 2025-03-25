namespace Exercicio21
{
    internal class Program
    {
        
        
        static long FactorialGenerator(int cn)
        {
            long factorial = 1;
            for (int i = cn; i >= 1; i--)
            {
                factorial *= i;

            }

            
            return factorial;
            
        }
        
        static void mainProgram()
        {
            Console.WriteLine("Informe um Valor Inteiro:\n");
            int chosenNum = int.Parse(Console.ReadLine());
            long factorial = FactorialGenerator(chosenNum);
            Console.WriteLine($"\n{chosenNum}! : {factorial}");
            Environment.Exit(0);
        }
        
        static void Main(string[] args)
        {
            mainProgram();

        }
    }
}
