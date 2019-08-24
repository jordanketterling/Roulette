using System;

namespace Roulette
{
    class Wheel
    {
        int wallet = 500;


        // Tuple<number, isRed, rowNumber, isLowSet, columnSet>

        Tuple<string, bool?, int, bool?, int>[] table =
        {
            Tuple.Create("0" , null as bool?,  0, null as bool?,  0)   ,
            Tuple.Create("1" ,  true as bool?,  1, true as bool?,  1)  , //1
            Tuple.Create("2" ,  false as bool?, 2, true as bool?,  1)  ,
            Tuple.Create("3" ,  true as bool?,  3, true as bool?,  1)  ,
            Tuple.Create("4" ,  false as bool?, 1, true as bool?,  4)  ,
            Tuple.Create("5" ,  true as bool?,  2, true as bool?,  4)  ,
            Tuple.Create("6" ,  false as bool?, 3, true as bool?,  4)  ,
            Tuple.Create("7" ,  true as bool?,  1, true as bool?,  7)  ,
            Tuple.Create("8" ,  false as bool?, 2, true as bool?,  7)  ,
            Tuple.Create("9" ,  true as bool?,  3, true as bool?,  7)  ,
            Tuple.Create("10", false as bool?, 1, true as bool?,  10)  , //10
            Tuple.Create("11", false as bool?, 2, true as bool?,  10)  ,
            Tuple.Create("12", true as bool?,  3, true as bool?,  10)  ,
            Tuple.Create("13", false as bool?, 1, true as bool?,  13)  ,
            Tuple.Create("14", true as bool?,  2, true as bool?,  13)  ,
            Tuple.Create("15", false as bool?, 3, true as bool?,  13)  ,
            Tuple.Create("16", true as bool?,  1, true as bool?,  16)  ,
            Tuple.Create("17", false as bool?, 2, true as bool?,  16)  ,
            Tuple.Create("18", true as bool?,  3, true as bool?,  16)  ,
            Tuple.Create("19", true as bool?,  1, false as bool?, 19)  ,
            Tuple.Create("20", false as bool?, 2, false as bool?, 19)  , //20
            Tuple.Create("21", true as bool?,  3, false as bool?, 19)  ,
            Tuple.Create("22", false as bool?, 1, false as bool?, 22)  ,
            Tuple.Create("23", true as bool?,  2, false as bool?, 22)  ,
            Tuple.Create("24", false as bool?, 3, false as bool?, 22)  ,
            Tuple.Create("25", true as bool?,  1, false as bool?, 25)  ,
            Tuple.Create("26", false as bool?, 2, false as bool?, 25)  ,
            Tuple.Create("27", true as bool?,  3, false as bool?, 25)  ,
            Tuple.Create("28", false as bool?, 1, false as bool?, 28)  ,
            Tuple.Create("29", false as bool?, 2, false as bool?, 28)  ,
            Tuple.Create("30", true as bool?,  3, false as bool?, 28)  ,//30
            Tuple.Create("31", false as bool?, 1, false as bool?, 31)  ,
            Tuple.Create("32", true as bool?,  2, false as bool?, 31)  ,
            Tuple.Create("33", false as bool?, 3, false as bool?, 31)  ,
            Tuple.Create("34", true as bool?,  1, false as bool?, 34)  ,
            Tuple.Create("35", false as bool?, 2, false as bool?, 34)  ,
            Tuple.Create("36", true as bool?,  3, false as bool?, 34)  ,
            Tuple.Create("00", null as bool?,  0, null as bool?,  0)   ,  //38    
            
        };


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

            Random random = new Random(38);

            int randomNumber = random.Next();

            if (randomNumber == finalNumberBet)
            {

            }



        }
        public void EvenOddBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on either Even or Odd?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Even. Enter 2 for Odd.");

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
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Red. Enter 2 for Black.");

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
            Console.WriteLine("Wuuld you like to bet on either the Lower Half or the Higher Half?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Lower Half. Enter 2 for Higher Half.");

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
            Console.WriteLine();
            Console.WriteLine("Enter 1 for First Dozen. Enter 2 for Second Dozen. Enter 3 for Third Dozen.");

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
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Row 1. Enter 2 for Row 2. Enter 3 for Row 3.");

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
            Console.WriteLine();
            Console.WriteLine("Enter 1 to select the 1 street.");
            Console.WriteLine("Enter 4 to select the 4 street.");
            Console.WriteLine("Enter 7 to select the 7 street.");
            Console.WriteLine("Enter 10 to select the 10 street.");
            Console.WriteLine("Enter 13 to select the 13 street.");
            Console.WriteLine("Enter 16 to select the 16 street.");
            Console.WriteLine("Enter 19 to select the 19 street.");
            Console.WriteLine("Enter 22 to select the 22 street.");
            Console.WriteLine("Enter 25 to select the 25 street.");
            Console.WriteLine("Enter 28 to select the 28 street.");
            Console.WriteLine("Enter 31 to select the 31 street.");
            Console.WriteLine("Enter 34 to select the 34 street.");

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
            Console.WriteLine();
            Console.WriteLine("Enter 1 to select the double street following 1.");
            Console.WriteLine("Enter 4 to select the double street following 4.");
            Console.WriteLine("Enter 7 to select the double street following 7.");
            Console.WriteLine("Enter 10 to select the double street following 10.");
            Console.WriteLine("Enter 13 to select the double street following 13.");
            Console.WriteLine("Enter 16 to select the double street following 16.");
            Console.WriteLine("Enter 19 to select the double street following 19.");
            Console.WriteLine("Enter 22 to select the double street following 22.");
            Console.WriteLine("Enter 25 to select the double street following 25.");
            Console.WriteLine("Enter 28 to select the double street following 28.");
            Console.WriteLine("Enter 31 to select the double street following 31.");

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
