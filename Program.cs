/*
    Author: Jesse Schmitt
    Date: 2/5/2020
    Comments:  This is my C# Console application that demonstrates a Method
*/



using System;
using System.Linq;

namespace Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Displays opening method
            Console.Write("Please Enter Your Name: ");
            // Calls method name

            name();
            
        }

        static void name()
        {
          
            // This variable will gather the users name
            string input = Console.ReadLine();
            // Varifies input is a valid name
            bool result = input.All(c => Char.IsLetter(c) || c == ' ');
            if (result == true)
            {

                // This variable will say hello and display the users name

                Console.WriteLine("Hello " + input);

                Console.WriteLine("Press any key to exit the program ...");
                // Pause the program and await the user to press any key
                Console.ReadKey(true);
            }


            else
            {
                // Rejects input and asks for a valid name
                Console.WriteLine("Please enter a valid name");
            }
        }
    }
}
