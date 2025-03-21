namespace Exercicio17
{
    internal class Program
    {
        /*Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
        contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
        variável C e mostrar seu conteúdo na tela.*/





        static void Main(string[] args)
        {
            Console.WriteLine("Declare o Primeiro Valor:\n");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Declare o Segundo Valor:\n");
            int b = int.Parse(Console.ReadLine());
            int c;
            if (a == b)
            {
                c = a + b;
            } else
            {
                c = a * b;
            }
            Console.WriteLine($"Valor de A: {a}\nValor de B: {b}\nValor de C: {c}");
        }
    }
}
