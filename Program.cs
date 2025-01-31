using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja a operação que deseja realizar 1 ou 2: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtrair();
                    break;
                default:
                    Console.WriteLine("Decida algo.");
                    break;
            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma é {resultado}");
        }

        static void Subtrair()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é {resultado}");
        }
    }
}