using System;
 
namespace Project
{
    class Project
    {         
        static void Main(string[] args)
        { 
            int height = 13;
            if ( height <= 12 )
            {   
                Console.WriteLine("Low bridge: ");
                Console.WriteLine ("proceed with caution.");
            }
            int sum = 21;
            if ( sum != 20 )
            Console.WriteLine ("You win ");
            else
            {
                Console.Write ("You lose ");
                Console.WriteLine ("the prize.");
            }
            if ( sum > 20 ) 
            {
                Console.WriteLine ("You win ");
            }
            else 
            {
                Console.Write ("You lose ");
                Console.WriteLine ("the prize.");
            }
        }
    }
}