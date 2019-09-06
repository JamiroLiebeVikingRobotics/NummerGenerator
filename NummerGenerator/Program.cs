using System;

namespace NummerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Genererar och sparar ett nummer mellan 0-100
            Random rnd = new Random();
            int num = rnd.Next(100);

            Boolean status = false;

            Console.WriteLine("Guess the number between 0-100");

            while (status == false)
            {
                Console.WriteLine("Please enter a number");

                string input = Console.ReadLine();
                int guess = int.Parse(input);

                //Ändrar "Status" om gissningen är rätt för att avsluta Loopen
                if (guess == num)
                {
                    status = true;
                    Console.WriteLine("Congrats you won!! ");
                }
                 
                
        

            }

        }
    }
}
