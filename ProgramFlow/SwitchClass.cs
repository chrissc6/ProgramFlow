using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFlow
{
    class SwitchClass
    {
        //Switch statement

        public void SwitchStatement()
        {
            int Grade;
            Console.WriteLine("Enter your grade number");
            string sgrade = Console.ReadLine();

            if (int.TryParse(sgrade, out Grade))
            {
                if(Grade <= 5)
                {
                    Grade = 0;
                }
                else if( Grade <= 8)
                {
                    Grade = 1;
                }
                else if(Grade <= 12)
                {
                    Grade = 2;
                }

                switch(Grade)
                {
                    case 0:
                        Console.WriteLine("Your in elementary school");
                        break;
                    case 1:
                        Console.WriteLine("Your in middle school");
                        break;
                    case 2:
                        Console.WriteLine("Your in high school");
                        break;
                    default:
                        Console.WriteLine("You are not in 1-12");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Didnt enter a NUMBER. Exiting program...");
                return;
            }
        }
    }
}
