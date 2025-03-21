namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu Nome:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Informe sua Idade:");
            int age = int.Parse(Console.ReadLine());
            int days = age * 365;

            Console.WriteLine($"{name}, você já viveu {days} dias!");
            Console.WriteLine("Pressione Enter para Fechar a Aplicação.");
            Console.ReadLine();
        }
    }
}
