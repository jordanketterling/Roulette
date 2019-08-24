using System;
using System.Collections.Generic;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class App
    {
        public void Run()
        {
            Random random = new Random(38);
        }
    }

    class Wheel
    {

        // FIRST SELECT MENU: USED TO SELECT WHAT TYPE OF BET THE USER WANTS

        public void BetSelect()
        {
            Console.Clear();
            Console.WriteLine("Please select which type of bet you would like to make.");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to select a Number bet.");
            Console.WriteLine("Enter 2 to select an Even/Odd bet.");
            Console.WriteLine("Enter 3 to select a Red/Black bet.");
            Console.WriteLine("Enter 4 to select a Low/High bet.");
            Console.WriteLine("Enter 5 to select a Dozens bet.");
            Console.WriteLine("Enter 6 to select a Row bet.");
            Console.WriteLine("Enter 7 to select a Street bet.");
            Console.WriteLine("Enter 8 to select a Double Street bet.");
            Console.WriteLine("Enter 9 to select a Split bet.");
            Console.WriteLine("Enter 10 to select a Corner bet.");

            string originalBet = Console.ReadLine();

            int finalSelect = int.Parse(originalBet);

            switch (finalSelect)
            {
                case 1:
                    NumberBet();
                    break;
                case 2:
                    EvenOddBet();
                    break;
                case 3:
                    RedBlackBet();
                    break;
                case 4:
                    LowHighBet();
                    break;
                case 5:
                    DozensBet();
                    break;
                case 6:
                    RowBet();
                    break;
                case 7:
                    StreetBet();
                    break;
                case 8:
                    DoubleStreetBet();
                    break;
                case 9:
                    SplitBet();
                    break;
                case 10:
                    CornerBet();
                    break;
                default:
                    BetSelect();
                    break;
            }
        }

        // SECOND SELECT MENU: USED TO SPECIFY WHAT FORM THE TYPE OF BET WILL TAKE ON

        public void NumberBet()
        {
            Console.Clear();
            Console.WriteLine("Which number would you like to select from 0-36, including 00?");
            string firstNumberBet = Console.ReadLine();
            int finalNumberBet = int.Parse(firstNumberBet);

            

        }
        public void EvenOddBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on either Even or Odd?");
            string firstEvenOddBet = Console.ReadLine();
            int finalEvenOddBet = int.Parse(firstEvenOddBet);

            switch (finalEvenOddBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                default:
                    EvenOddBet();
                    break;
            }
        }
        public void RedBlackBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on either Red or Black?");

            string firstRedBlackBet = Console.ReadLine();
            int finalRedBlackBet = int.Parse(firstRedBlackBet);

            switch (finalRedBlackBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                default:
                    RedBlackBet();
                    break;
            }
        }
        public void LowHighBet()
        {
            Console.Clear();
            Console.WriteLine("WOuld you like to bet on either the Lower Half or the Top Half?");

            string firstLowHighBet = Console.ReadLine();
            int finalLowHighBet = int.Parse(firstLowHighBet);

            switch (finalLowHighBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                default:
                    LowHighBet();
                    break;
            }
        }
        public void DozensBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on the First, Second, or Third Dozen?");

            string firstDozensBet = Console.ReadLine();
            int finalDozensBet = int.Parse(firstDozensBet);

            switch (finalDozensBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    DozensBet();
                    break;
            }
        }
        public void RowBet()
        {
            Console.Clear();
            Console.WriteLine("Which Row would you like to select?");

            string firstRowBet = Console.ReadLine();
            int finalRowBet = int.Parse(firstRowBet);

            switch (finalRowBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    RowBet();
                    break;
            }
        }
        public void StreetBet()
        {
            Console.Clear();
            Console.WriteLine("Which Street would you like to bet on?");

            string firstStreetBet = Console.ReadLine();
            int finalStreetBet = int.Parse(firstStreetBet);

            switch (finalStreetBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                default:
                    StreetBet();
                    break;
            }
        }
        public void DoubleStreetBet()
        {
            Console.Clear();
            Console.WriteLine("Which Double Street would you like to bet on?");

            string firstDoubleStreetBet = Console.ReadLine();
            int finalDoubleStreetBet = int.Parse(firstDoubleStreetBet);

            switch (finalDoubleStreetBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                default:
                    DoubleStreetBet();
                    break;
            }
        }
        public void SplitBet()
        {
            Console.Clear();
            Console.WriteLine("Which split would you like to bet on?");
            Console.WriteLine();
            Console.WriteLine();

            string firstSplitBet = Console.ReadLine();
            int finalSplitBet = int.Parse(firstSplitBet);

            switch (finalSplitBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 14:

                    break;
                case 15:

                    break;
                case 16:

                    break;
                case 17:

                    break;
                case 18:

                    break;
                case 19:

                    break;
                case 20:

                    break;
                case 21:

                    break;
                case 22:

                    break;
                case 23:

                    break;
                case 24:

                    break;
                case 25:

                    break;
                case 26:

                    break;
                case 27:

                    break;
                case 28:

                    break;
                case 29:

                    break;
                case 30:

                    break;
                case 31:

                    break;
                case 32:

                    break;
                case 33:

                    break;
                case 34:

                    break;
                case 35:

                    break;
                case 36:

                    break;
                case 37:

                    break;
                case 38:

                    break;
                case 39:

                    break;
                case 40:

                    break;
                case 41:

                    break;
                case 42:

                    break;
                case 43:

                    break;
                case 44:

                    break;
                case 45:

                    break;
                case 46:

                    break;
                case 47:

                    break;
                case 48:

                    break;
                case 49:

                    break;
                case 50:

                    break;
                case 51:

                    break;
                case 52:

                    break;
                case 53:

                    break;
                case 54:

                    break;
                case 55:

                    break;
                case 56:

                    break;
                case 57:

                    break;
                default:
                    SplitBet();
                    break;
            }
        }
        public void CornerBet()
        {
            Console.Clear();
            Console.WriteLine("Which corner would you like to bet on?");

            string firstCornerBet = Console.ReadLine();
            int finalCornerBet = int.Parse(firstCornerBet);

            switch (finalCornerBet)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                default:
                    CornerBet();
                    break;
            }
        }
    }
}
