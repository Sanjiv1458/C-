using System;

namespace project
{
    class Task6
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

            //printing array's elements

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            List<String> myStudentList = new List<string>();
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(1, 12);

            Console.WriteLine("you need to add "+ randomNumber + " students to your class list");
            for(int i =0; i < randomNumber; i++)
            {
                Console.Write("please enter the name of Student " + (i + 1) + ": ");
                myStudentList.Add(Console.ReadLine());
                Console.WriteLine();
            }

            for(int i = 0; i < randomNumber; i++) 
            {
                Console.WriteLine(myStudentList[i] + "\n ");
            }
        }
    }
}