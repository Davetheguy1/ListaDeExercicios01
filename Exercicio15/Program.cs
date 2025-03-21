namespace Exercicio15
{
    internal class Program
    {
        
        static void ValueInput()
        {
            Console.WriteLine("Calculadora de IMC\n------------------\n\n");
            Console.WriteLine("Insira seu Peso:\n");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua Altura:\n");
            double height = double.Parse(Console.ReadLine());

            double imcValue = IMCCalc(weight, height);
            string imcClass = IMCclass(imcValue);

            Console.WriteLine($"Seu IMC; {imcValue}\nSua Classificação: {imcClass}\n");
            
            Enquire();
        }
        
        
        
        
        static double IMCCalc(double weight, double height)
        {
            double imc = weight / Math.Pow(height, 2);
            return imc;
        } 
        
        static string IMCclass(double imc)
        {
            string classification;

            if (imc <= 18.5)
            {
                classification = "Abaixo do Peso";
            } else if (18.5 < imc && imc <= 25)
            {
                 classification = "Peso Normal";
            } else if (25 < imc && imc <= 30)
            {
                classification = "Acima do Peso";
            } else
            {
                classification = "Obeso.";
            }

            return classification;
        }

        
        static void Enquire()
        {
            Console.WriteLine("\nCálculo FInalizado, Deseja Fazer outro Cálculo? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                ValueInput();
            } else if (answer == "n")
            {
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Erro, Escolha uma Opção Válida.");
                Enquire();
            }
        }
        
        
        static void Main(string[] args)
        {
            ValueInput();
        }
    }
}
