/*
    Author: Jesse Schmitt
    Date: 2/5/2020
    Comments:  This is my C# Console application that demonstrates a Method
*/



using System;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");

            {
                // This variable will gather the users name
                string input = Console.ReadLine();
                // This variable will say hello and display the users name
                Console.WriteLine("Hello " + input);

                Console.WriteLine("Press any key to exit the program ...");
                // Pause the program and await the user to press any key
                Console.ReadKey(true);
            }
        }
    }
}
