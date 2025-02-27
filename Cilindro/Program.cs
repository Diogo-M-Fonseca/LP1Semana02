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

            double v = Math.PI * Math.Pow(raio,2)*altura;


            double sa = 2*Math.PI*raio*(raio + altura);



        }
    }
}
