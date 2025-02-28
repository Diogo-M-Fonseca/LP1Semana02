using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool a = true;
           int tentativa = 0;
           Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            while(a == true)
            {
                Console.WriteLine("Choose a number between 0 and 30: ");
                string read = Console.ReadLine();
                int rread = int.Parse(read);
                 
                if (rread < 0 || rread > 30 )
                {
                    Console.WriteLine("must be between 0 and 30. Try again.");
                }
                else if (rread > numberToGuess)
                {
                    Console.WriteLine($"number is lower than {rread}. Try again");
                    tentativa += 1;
                }
                else if (rread < numberToGuess)
                {
                    Console.WriteLine($"number is higher than {rread}. Try again");
                    tentativa += 1;
                }
                else if (rread == numberToGuess)
                {
                    tentativa += 1;
                    Console.WriteLine($"you found the hidden number {numberToGuess} after {tentativa} tries");
                    a = false;
                }

            }
         }
    }
}
