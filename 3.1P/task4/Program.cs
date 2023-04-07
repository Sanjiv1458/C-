using System;

namespace project
{
    class Task4
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[6];
            studentNames[0] = "my";
            studentNames[1] = "name";
            studentNames[2] = "is";
            studentNames[3] = "sanjiv";
            studentNames[4] = "kumar";
            studentNames[5] = "singh";
            
            //printing array's elements

            for(int i =0; i<studentNames.Length; i++)
            {
                Console.Write(studentNames[i]+ " ");
            }
        }
    }
}