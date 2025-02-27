using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Inserir um número inteiro-não negativo: ");

            string read = Console.ReadLine();
            byte num = byte.Parse(read);

            Console.WriteLine(num/2);
            Console.WriteLine(num<<3);
            Console.WriteLine(num^6);
            Console.WriteLine(num>10);
        }
    }
}
