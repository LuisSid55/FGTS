using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario, fgts;
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n---FGTS---\n");
            Console.ResetColor();
            Console.WriteLine("Para calcular o FGTS, digite o salário abaixo\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sálario: R$ ");
            salario = Convert.ToDecimal(Console.ReadLine());

            fgts = salario * 8 / 100; 

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nSeu FGTS: {fgts:C}\n");
            Console.ResetColor();
        }
    }
}
