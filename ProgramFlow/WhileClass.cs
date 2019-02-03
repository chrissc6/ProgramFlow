using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFlow
{
    class WhileClass
    {
        //While loop
        //loop executes only if condition is true and continue until false

        public void WhileLoop()
        {
            int x = 1;
            int max = 11;

            Console.WriteLine($"Starting while loop counting to {max - 1}");
            while (x < max) //count to max
            {
                Console.WriteLine($"x is {x}");
                x++;
            }
            Console.WriteLine("Done with while loop");

        }


        //Do While loop
        //loop executes at least once, if condition is true continues until false

        public void DoWhileLoop()
        {
            int x = 3;
            int max = 1;

            do
            {
                Console.WriteLine($"x is {x}, max is {max}");
                x++;
            } while (x < max);

            Console.WriteLine($"Done with do while loop x is {x}");
        }

        //Number guess using do while
        

        public void NumberGuess()
        {
            Random rng = new Random();
            int x = rng.Next(1, 100);
            int guess;

            do
            {
                Console.WriteLine("Guess my number it between 1-100");
                string sguess = (Console.ReadLine());
                


                if(int.TryParse(sguess, out guess))
                {
                    if (guess == x)
                    {
                        Console.WriteLine("Yes thats my number. \nIf you want to play again enter 'Y'");
                        string ans = Console.ReadLine();
                        if (ans == "Y" || ans == "y")
                            NumberGuess();
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (guess > x)
                        {
                            Console.WriteLine("Your guess is to high.");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is to low.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a NUMBER");
                    continue;
                }

            } while (guess != x);

        }

    }
}
/*
 * while(i < 10)
 * {
 *  keep looping through here as long as i is less than 10
 * }
 */