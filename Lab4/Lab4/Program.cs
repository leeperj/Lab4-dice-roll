    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Lab4
    {
        class Program
        {
            public static Random dice = new Random();
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, welcome to the Casino!");
                bool repeat = true;
                while (repeat)
                {
                    Console.WriteLine("Would you like to roll the dice? y/n");
                    string yesno = Console.ReadLine().ToLower();
                 if (yesno == "yes" || yesno == "y")
                {
                    Console.WriteLine("Ok, Great! How many sides should the dice have?");
                    string sides = Console.ReadLine();
                    int sides2;
                        
                    if (int.TryParse(sides, out sides2))
                    {
                        int roll1 = DiceRoll(sides2);
                        int roll2 = DiceRoll(sides2);
                        if (roll1 == 1 && roll2 == 1)
                        {
                            Console.WriteLine(roll1);
                            Console.WriteLine(roll2);
                            Console.WriteLine("You rolled snake eyes!");
                        }
                        else if (roll1 == 6 && roll2 == 6)
                        {
                            Console.WriteLine(roll1);
                            Console.WriteLine(roll2);
                            Console.WriteLine("You rolled box cars!");
                        }
                        else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
                        {
                            Console.WriteLine(roll1);
                            Console.WriteLine(roll2);
                            Console.WriteLine("You rolled a crap number.");
                        }
                        else
                        {
                            Console.WriteLine(roll1);
                            Console.WriteLine(roll2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a proper input. Try again.");
                    }
                    
                    }
                    else if (yesno == "no" || yesno == "n")
                    {
                        Console.WriteLine("Thats ok, have a nice day!");
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid response.");
                    }

                }
            }

            public static int DiceRoll(int userChoice)
            {
           
                int rolldice = dice.Next(1, userChoice+1);
                return rolldice;
           
            }


        


        }
    }
