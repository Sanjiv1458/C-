using System;

namespace project
{
    class Task3
    {
        static void Main(string[] args)
        {
            int[] studentArray = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
            
            int total = 0;
            //printing array's elements

            for(int i =0; i<studentArray.Length; i++)
            {
                total += studentArray[i];
            }

            Console.WriteLine("The total marks for the student is: " + total);
            Console.WriteLine("This consist of " + studentArray.Length + " marks");
            Console.WriteLine("Therefore the average marks is " + (total/studentArray.Length));
        }
    }
}