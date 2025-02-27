using System;
using System.Text;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero inteiro");
            string read = Console.ReadLine(); // read line 
            sbyte bread = sbyte.Parse(read); // converts to sbyte
            Console.WriteLine(--bread); // decrement sbyte variable
            Console.WriteLine(++bread); // increment sbyte variable
        }
    }
}
