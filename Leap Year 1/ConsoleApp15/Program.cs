using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main()
        {
            bool isLeapYear = false;

            Console.WriteLine("Please Enter a month (1-12)");
            int myMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter a Year");
            double myYear = double.Parse(Console.ReadLine());

            if ((myYear % 4 == 0 && myYear % 100 != 0) || (myYear % 400 == 0))
            {
                isLeapYear = true;
            }

            switch (myMonth)
            {

                case 1:
                    Console.WriteLine($"There are 31 Days in January {myYear} ");
                    break;

                case 2:
                    if (isLeapYear == true)
                    {
                        Console.WriteLine($"There are 29 days in Febuary {myYear}");
                    }
                    if (isLeapYear == false)
                    {
                        Console.WriteLine($"There are 28 days in Febuary {myYear}");
                    }
                    break;

                case 3:
                    Console.WriteLine($"There are 31 Days in March {myYear} ");
                    break;

                case 4:
                    Console.WriteLine($"There are 30 Days in April {myYear} ");
                    break;

                case 5:
                    Console.WriteLine($"There are 31 Days in May {myYear} ");
                    break;

                case 6:
                    Console.WriteLine($"There are 30 Days in June {myYear} ");
                    break;

                case 7:
                    Console.WriteLine($"There are 31 Days in July {myYear} ");
                    break;

                case 8:
                    Console.WriteLine($"There are 31 Days in August {myYear} ");
                    break;

                case 9:
                    Console.WriteLine($"There are 30 Days in September {myYear} ");
                    break;

                case 10:
                    Console.WriteLine($"There are 31 Days in October {myYear} ");
                    break;

                case 11:
                    Console.WriteLine($"There are 30 Days in November {myYear} ");
                    break;

                case 12:
                    Console.WriteLine($"There are 31 Days in December {myYear} ");
                    break;

                default:
                    Console.WriteLine("Bye");
                    break;
            }
        }
    }
}
