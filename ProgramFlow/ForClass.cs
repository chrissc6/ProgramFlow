using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgramFlow
{
    class ForClass
    {

        //For loop, executed a set number of times.
        //used to count things, or loop a list of a known size
        //you can count by different numbers doesnt have to be one, or even count down
        //3 parts: 1-initializer, 2-condition, 3-iterator


        public void ForLoop()
        {
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine($"x is {x}");
            }
            Console.WriteLine("Done with for loop.");
        }

        //For loop with break statement

        public void ForLoopBreak()
        {
            for (int x = 1; x < 100; x++)
            {
                if (x == 3)
                    break;

                Console.WriteLine($"x is {x}");
            }
            Console.WriteLine("Done with for loop with break.");
        }

        //For loop with continue statement

        public void ForLoopContinue()
        {
            for (int x = 1; x < 10; x++)
            {
                if (x == 3 || x == 9)
                    continue;

                Console.WriteLine($"x is {x}");
            }
            Console.WriteLine("Done with for loop with continue.");
        }

        //Dice game with for loop

        public void DiceGame()
        {
            Console.WriteLine("Starting Dice Game... \nRoll a 7 or 11 to win!");
            Random rng = new Random();


            int rolls = 100;
            int x = 0;

            for (int i = 0; i <= rolls; i++)
            {
                int die1 = rng.Next(1, 7);
                int die2 = rng.Next(1, 7);
                if (die1 + die2 == 7 || die1 + die2 == 11)
                    x++;

            }
            Console.WriteLine($"Out of {rolls} rolls, you won {x} times!");
        }

        //Multiplication table with for loop

        public void MultiplicationTable()
        {
            Console.WriteLine("Multiplication Table:");
            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12");

            for (int a = 1; a <= 12; a++)
            {
                Console.Write(a);
                for (int b = 1; b <= 12; b++)
                {
                    Console.Write("\t{0}", a * b); //substitution string product of a and b
                }
                Console.WriteLine();
            }
        }

        //Foreach loop

        public void ForEach()
        {
            string text = "Foreach statement \n";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(75);
            }

            var NumbersList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            int count = 0;
            foreach (int IndexElement in NumbersList) //foreach variable in collection
            {
                count++;
                Console.WriteLine($"Index Element #{count}: {IndexElement}");
            }
            Console.WriteLine($"Number of elements: {count}");
        }

        

    }
}
/*
 * for(int i = 0; 1 < 10; i++)
 * {
 *  loop 10 times
 * }
 * 
 * foreach(myclass mc in mycollection)
 * {
 *  execute once for each mc object in mycollection
 * }
 */