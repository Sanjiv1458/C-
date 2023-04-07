using System;
 
namespace Project
{
    class Project
    {         
        static void Main(string[] args)
        {
            int number = 50;
            if (number == 50) 
            {
                Console.WriteLine("Number is 50");
            }
            else if (number >= 50 && number <= 100) 
            {
                Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100"); 
            }
            
            double score = 40;
            if (score > 40)
            {
                Console.WriteLine("You passed the exam!");
            } 
            else if(score < 40)
            {
                Console.WriteLine("You failed the exam!");
            }
            Console.WriteLine("Please Enter a option: ");
            int n1  = Convert.ToInt16(Console.ReadLine());
            switch (n1) 
            {
                case 1: Console.WriteLine("The number is 1"); break;
                case 2: Console.WriteLine ("The number is 2"); break;
                default: Console.WriteLine ("The number is not 1 or 2"); break;
            }
            Console.WriteLine("Please Enter a option: ");
            int n2  = Convert.ToInt16(Console.ReadLine());
            switch (n2) 
            {
                case 1: Console.WriteLine ("A"); break;
                case 2: Console.WriteLine ("B"); break;
                default: Console.WriteLine ("C"); break;
            }
        }
    }
}