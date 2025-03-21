namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare o Primeiro Valor:\n");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Valor:\n");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Terceiro Valor:\n");
            int z = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int> {x,y,z};

            numbers.Sort();
            numbers.Reverse();

            foreach (int num in numbers) {
                Console.WriteLine("\n--------------\n" + num + " ");
            }
        }
    }
}
