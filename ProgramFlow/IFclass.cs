using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFlow
{
    class IFclass
    {
        //IF statement, use boolean expressions, codeblock excuted if true, 
        //code block optional with only one statement
        int i = 5;

        public void IfStatement()
        {
            if (i < 10)
            {
                Console.WriteLine("True");
            }
        }

        //IF ELSE statement,use boolean expressions, codeblock excuted if true,
        //else used to do something else if false, checks 2 conditions
        int x = 5;
        int y = 10;

        public void IfElseStatement()
        {
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is less than y");
            }
        }

        //ELSE IF statement, use boolean expressions, codeblock excuted if true,
        //elseif used to do something else if 1st if is false, else used last if nothing is true
        //check 2 or more conditions, can have as many else if as needed
        int a = 5;
        int b = 10;
        int c = 15;

        public void ElseIfStatement()
        {
            if (a > b && a > c)
            {
                Console.WriteLine($"A is the biggest value");
            }

            else if (b > a && b > c)
            {
                Console.WriteLine($"B is the biggest value");
            }

            else
            {
                Console.WriteLine($"C is the biggest value");
            }
        }

        //Coin flip using if else
        int coin;
        Random rng = new Random();

        public void CoinFlipper()
        {
            coin = rng.Next(2);

            Console.WriteLine("Press ENTER to flip the coin, or 99 to quit");
            string quit = (Console.ReadLine());

            if(quit == "99")
            {
                return;
            }
            else
            {
                if (coin == 0)
                {
                    Console.WriteLine("Heads.");
                    CoinFlipper();
                }

                else
                {
                    Console.WriteLine("Tails.");
                    CoinFlipper();
                }
            }
        }
        
    }
}
/*
 * if(i < 10)
 * {
 *  go here if i is less than 10
 * }
 * else
 * {
 *  go here otherwise
 * }
 */