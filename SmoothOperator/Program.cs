using System;
using System.Text;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero inteiro");
            string read = Console.ReadLine();
            sbyte bread = sbyte.Parse(read);
            Console.WriteLine(--bread);
            Console.WriteLine(++bread);
        }
    }
}
