namespace Exercicio22
{
    internal class Program
    { 
        //não consegui fazer esse.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número:");
            int chosenNum = int.Parse(Console.ReadLine());

            int num1 = 0, num2 = 1;

            Console.Write(num1 + "," + num2 + ",");

            while (num2 < chosenNum)
            {
                int num3 = num1 + num2;
                Console.Write(num3 + ",");
                num1 = num2;
                num2 = num3;
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
