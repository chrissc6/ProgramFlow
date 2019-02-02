using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Flow in C#!");

            var ic = new IFclass();
            ic.IfStatement();
            ic.IfElseStatement();
            ic.ElseIfStatement();
            ic.CoinFlip();

        }
    }
}


// = assignment
// == compasrison