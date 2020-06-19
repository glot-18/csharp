using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_loops_while_GuessNumberPlayOnce
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int num = rnd.Next(1, 101);


            int playcount = 1;
            bool PlayAgain = true;
            int guess;
            int numAttempts = 0;
            int MAX_ATTEMPTS = 100;
            bool guessNotCorrect = true;

            do
            {

                while (guessNotCorrect && numAttempts < MAX_ATTEMPTS)
                {
                    Console.Write("Guess a number (1-100): ");
                    guess = int.Parse(Console.ReadLine());
                    numAttempts++;
                    Console.WriteLine($"You have guessed {numAttempts} times");

                    if (guess < num)
                    {
                        Console.WriteLine("Too Low!");
                    }
                    else if (guess > num)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        guessNotCorrect = false;
                    }
                }

                if (guessNotCorrect)
                {
                    Console.WriteLine($"You ran out of tries! Number was {num}.");
                }
                else
                {
                    Console.WriteLine("Hooray! You got the number!");
                }


                Console.WriteLine("Would you like to play another game? (Y/N)");
                string play = Console.ReadLine();



                if (play == "Y")
                {
                    Console.WriteLine("Okay");
                    playcount++;
                    guessNotCorrect = true;
                    numAttempts = 0;
                }
                else if (play == "N")
                {
                    PlayAgain = false;

                }

                else
                {
                    PlayAgain = false;

                }
            } while (PlayAgain != false);

            Console.WriteLine($"You have played {playcount} times");
        }
    }
}
