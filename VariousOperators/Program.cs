using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Inserir um número inteiro-não negativo: ");

            string read = Console.ReadLine();
            byte num = byte.Parse(read); // byte.parse converte string em byte

            Console.WriteLine(num/2); // divisão inteira
            Console.WriteLine(num<<3); // shift left
            Console.WriteLine(num^6); // xor
            Console.WriteLine(num>10); // maior que o operador
        }
    }
}
