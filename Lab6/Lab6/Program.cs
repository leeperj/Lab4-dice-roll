using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number");
                int input = int.Parse(Console.ReadLine());
                Display(input);

                Console.WriteLine("Would you like to go again?");
                string answer = Console.ReadLine().ToLower();
                if(answer == "n" || answer == "no")
                {

                    break;
                }
            }
            
        }
        public static void Display(int num1)
        {
            
            
            Console.WriteLine("Number\tSquared\tCubed");
            for(int i = 1; i <= num1; i++)
            {
        
                Console.WriteLine($"{i}\t{NumberSquared(i)}\t{NumberCubed(i)}\t");
            }
        }

       

        public static int NumberSquared(int numb1)
        {
            return numb1 *= numb1;
        }
            
        public static int NumberCubed(int numb1)
        {
            return numb1 * numb1 * numb1;
        }
    }
}
