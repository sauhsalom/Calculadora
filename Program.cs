using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Calculadora()
        {
            int valor1;
            int valor2;

            Console.WriteLine("bem vindo a minha calculadora");
            Console.WriteLine("______________________________________");
            Console.WriteLine("por gentileza digite abaixo o primeiro valor");

            valor1 = Convert.ToInt32(Console.ReadLine());

            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("bem vindo a minha calculadora");
            Console.WriteLine("______________________________________");
            Console.WriteLine("por gentileza digite abaixo o primeiro valor");

        }
    }
}
