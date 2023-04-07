using System;


namespace project
{
    class Task5
    {
        static void Main(string[] args)
        {
            double [] myArray = new double[10];
            double CurrentLargest = 0, CurrentSmallest = 0;
            int CurrentSize = 0;

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                Console.Write("please Enter " + CurrentSize + "(index) number: ");
                myArray[CurrentSize] = Convert.ToDouble(Console.ReadLine());
            }

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                CurrentLargest = myArray[0];
                if(CurrentLargest < myArray[CurrentSize])
                {
                    CurrentLargest = myArray[CurrentSize];
                }
            }

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                CurrentSmallest = myArray[0];
                if(CurrentSmallest > myArray[CurrentSize])
                {
                    CurrentSmallest = myArray[CurrentSize];
                }
            }

            Console.WriteLine("====: array :====");

            for(CurrentSize =0;  CurrentSize< 10; CurrentSize++)
            {
                Console.WriteLine("Index(" +CurrentSize +")  " +myArray[CurrentSize]);
            }
            Console.WriteLine("largest number in array is "+ CurrentLargest);
            Console.WriteLine("smallest number in array is "+CurrentSmallest);
        }
    }
}