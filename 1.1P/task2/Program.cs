using System;

namespace Project
{
    class Project
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.Write("Enter a number between 1 to 9: ");
            number = Convert.ToInt16(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("TWO");
                    break;
                case 3:
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    Console.WriteLine("FOUR");
                    break;
                case 5:
                    Console.WriteLine("FIVE");
                    break;
                case 6:
                    Console.WriteLine("SIX");
                    break;
                case 7:
                    Console.WriteLine("SEVEN");
                    break;
                case 8:
                    Console.WriteLine("EIGHT");
                    break;
                case 9:
                    Console.WriteLine("NINE");
                    break;
                default:
                    Console.WriteLine("ERROR: you must enter an integer between 1 to 9");
                    break;
            }
        }
    }
}