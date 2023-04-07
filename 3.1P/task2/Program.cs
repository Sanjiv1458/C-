using System;

namespace project
{
    class Task2
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            myArray[0] = 0;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 4;
            myArray[5] = 5;
            myArray[6] = 6;
            myArray[7] = 7;
            myArray[8] = 8;
            myArray[9] = 9;
            
            //printing array's elements

            for(int i =0; i<10; i++)
            {
                Console.WriteLine("The element at position " + " in the arrary is " + myArray[1]);
            }
        }
    }
}