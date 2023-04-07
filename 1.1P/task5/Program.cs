using System;
 
namespace MicroWave
{
    class MicroWave
    {         
        static void Main(string[] args)
        {
            Console.Write("Enter the time taken to heat one item: ");
            int t = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the item: ");
            int item = Convert.ToInt16(Console.ReadLine());;
            
            while(item !=0)
            {
                Console.Write("Enter the number of item you want to heat: ");
                item = Convert.ToInt16(Console.ReadLine());
                if(item == 1)
                {
                    int time = t * 1;
                    Console.Write("Time taken for 1 item is ");
                    Console.WriteLine(time);
                }
                else if(item == 2)
                {
                    int time = t + t/2;
                    Console.Write("Time taken for 2 item is ");
                    Console.WriteLine(time);
                }
                else if(item == 3)
                {
                    int time = 2 * t;
                    Console.Write("Time taken for 3 item is ");
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("Heating of more than three items at once is not recommended.");
                }
            }
            Console.WriteLine("There is not any item in Microwave!!!");
        }
    }
}