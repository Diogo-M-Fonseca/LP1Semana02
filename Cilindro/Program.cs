using System;
using System.Data;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Inserir altura do cilindro: ");
            string rread = Console.ReadLine();
            Console.WriteLine("Inserir raio do cilindro: ");
            string read = Console.ReadLine();

            double altura = double.Parse(rread);
            double raio = double.Parse(read);

            double v = Math.PI * Math.Pow(raio,2)*altura; // V=pi * r^2 * a


            double sa = 2*Math.PI*raio*(raio + altura); // Sa=2pi*r*(r+a)

            Console.WriteLine($"{v:f3}"); // lembrar de tirar duvida sobre f3
            Console.WriteLine($"{sa:f3}");



        }
    }
}
