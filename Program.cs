using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("opções disponíveis:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.Write("\nSelecione uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break; 
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break; 
                default:
                    Menu();
                    break;
                
            }
        }
        static void Soma()
        {
            
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor + segundoValor;

            Console.WriteLine($"\nO resultado da soma é {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            
            Console.Write("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor - segundoValor;

            Console.WriteLine($"\nO resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor / segundoValor;

            Console.WriteLine($"\nO resultado da divisão é: {resultado}");
            
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor * segundoValor;

            Console.WriteLine($"\nO resultado da multiplicação é {resultado}");

            Console.ReadKey();
            Menu();
        }
    } 


}
