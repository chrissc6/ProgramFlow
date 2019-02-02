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
            ic.CoinFlipper();

            var wc = new WhileClass();
            wc.WhileLoop();
            wc.DoWhileLoop();
            wc.NumberGuess();

        }
    }
}


// = assignment
// == compasrison