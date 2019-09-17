using System;

namespace NummerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genererar och sparar ett nummer mellan 0-100
            Random rnd = new Random();
            int num = rnd.Next(100);
            int raknare = 0;
            Boolean status = false;

            Console.WriteLine("Guess the number between 0-100");
            //Skapar en While loop tills användaren gissar rätt
            while (status == false)
            {

                Console.WriteLine("Please enter a number");
                raknare ++ ;
                string input = Console.ReadLine();
                //Ändrar stringen till en int om möjligt
                int.TryParse(input, out int guess);


                //Ändrar "Status" om gissningen är rätt för att avsluta Loopen
                if (guess == num)
                {
                    status = true;
                    Console.WriteLine("Congrats you won!! ");
                    Console.WriteLine("Guesses: " + raknare);
                }
                //Ger ledtrådar till användaren
                else
                {
                    if (guess < num)
                    {
                        Console.WriteLine("Your guess is too low!");
                    }
                    else
                        Console.WriteLine("Your guesss is too high");
                }
            }

        }
    }
}
