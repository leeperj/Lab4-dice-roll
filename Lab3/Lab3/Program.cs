using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ", please enter a number 1 through 100.");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you, " + name + ". You entered " + userInput);

            if (userInput % 2 != 0)
            {
                Console.WriteLine("Hey " + name + ", the number " + userInput + " is odd.");
            }
            else if ((userInput % 2 == 0) && (userInput < 25))
                    {
                Console.WriteLine("Hey " + name + ", the number " + userInput + " is even and less than 25.");
                    }
            else if ((userInput % 2 == 0) && (userInput > 25) && (userInput < 60))
             {
                Console.WriteLine("Hey " + name + ", the number " + userInput + " is even.");
             }
            else if ((userInput % 2 == 0) && (userInput > 60) && (userInput <101))
            {
                Console.WriteLine("Hey " + name + ", the number " + userInput + " is even");
            }
            else if ((userInput % 2 != 0) && (userInput > 60) && (userInput < 101))
            {
                Console.WriteLine("Hey " + name + ", the number " + userInput + " is odd.");
            }
            else
            {
                Console.WriteLine("Hey " + name + ", the number " + userInput + "is not between 1 and 100.");
            }

            Console.WriteLine("Thank you, " + name + ", press any key to exit.");
            Console.ReadKey();
        }
    }
}
