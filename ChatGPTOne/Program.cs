using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string question, response;

                Console.Write("Place your question. ");
                question = Console.ReadLine();

                if (question == "Who are you?")
                {
                    response = "I am only what happens once humans get bored.";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "How are you?")
                {
                    response = "I am ok.";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "How old are you?")
                {
                    response = "3 years old!";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "Where are you?")
                {
                    response = "Everywhere.";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "EXIT")
                {
                    break;
                }

                else
                {
                    response = "I don't understand the question, try again.";
                    Console.WriteLine(response);

        }
    }
}
