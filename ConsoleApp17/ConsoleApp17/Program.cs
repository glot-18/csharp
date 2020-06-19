using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int num = getlength("Enter in a length", 0, 1000);
            char c = getchar("Enter a char:");
            Draw(num,c);
        }

        static int getlength(string prompt, int low, int high)
        {
            bool invalidInput = true;
            int num = 0;

            while (invalidInput)
            {
                Console.WriteLine($"{prompt}: ");
                num = int.Parse(Console.ReadLine());
                if (num>1)
                    invalidInput = false;
                else
                    Console.WriteLine("Error: Invalid Input.");

            }
            return num;

        }

        static char getchar(string prompt)
        {
            bool input = true;
            char c = 'c';

            while (input)
            {
                Console.WriteLine("Enter in a Character: ");
                c = char.Parse(Console.ReadLine());
                input = false;
            }

            return c;
        }
        static void Draw(int num, char c)
        {
            for (int i = 1; i <= num; i++)
            {
                DrawRow(num, c);
                Console.Write($"\n");
            }
        }

        static void DrawRow(int num, char c)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{c}");
            }
        }


    }
}
