using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
           int tentativa = 0;
            while(true)
            {
                
                Random rnd = new Random();
                int numberToGuess = rnd.Next(31);

                Console.WriteLine("inserir um numero inteiro entre 0 e 30: ");
                string read = Console.ReadLine();
                int rread = int.Parse(read);
                 
                if (rread < 0 )
                {
                    Console.WriteLine("O numero escolhido é menor que zero");
                }
                else if (rread > 30)
                {
                    Console.WriteLine("o numero escolhido é maior que 30");
                }
                else if (rread > numberToGuess)
                {
                    Console.WriteLine("o numero é maior que o numero aleatorio");
                    tentativa += 1;
                }
                else if (rread < numberToGuess)
                {
                    Console.WriteLine("o numero é menor que o numero aleatorio");
                    tentativa += 1;
                }
                
            }
            }
        }
    }
}
