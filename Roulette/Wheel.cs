using System;

namespace Roulette
{
    public class Wheel
    {
        Random spin = new Random();

        // Tuple<number, isRed, dozenNumber, isLowSet, row, column>

        Tuple<string, bool?, int, bool?, int, int>[] table =
        {
            Tuple.Create( "0" , null  as bool?, 0, null  as bool?, 0, 0),
            Tuple.Create( "1" , true  as bool?, 1, true  as bool?, 1, 1), //1
            Tuple.Create( "2" , false as bool?, 1, true  as bool?, 2, 1),
            Tuple.Create( "3" , true  as bool?, 1, true  as bool?, 3, 1),
            Tuple.Create( "4" , false as bool?, 1, true  as bool?, 1, 4),
            Tuple.Create( "5" , true  as bool?, 1, true  as bool?, 2, 4),
            Tuple.Create( "6" , false as bool?, 1, true  as bool?, 3, 4),
            Tuple.Create( "7" , true  as bool?, 1, true  as bool?, 1, 7),
            Tuple.Create( "8" , false as bool?, 1, true  as bool?, 2, 7),
            Tuple.Create( "9" , true  as bool?, 1, true  as bool?, 3, 7),
            Tuple.Create( "10", false as bool?, 1, true  as bool?, 1, 10), //10
            Tuple.Create( "11", false as bool?, 1, true  as bool?, 2, 10),
            Tuple.Create( "12", true  as bool?, 1, true  as bool?, 3, 10),
            Tuple.Create( "13", false as bool?, 2, true  as bool?, 1, 13),
            Tuple.Create( "14", true  as bool?, 2, true  as bool?, 2, 13),
            Tuple.Create( "15", false as bool?, 2, true  as bool?, 3, 13),
            Tuple.Create( "16", true  as bool?, 2, true  as bool?, 1, 16),
            Tuple.Create( "17", false as bool?, 2, true  as bool?, 2, 16),
            Tuple.Create( "18", true  as bool?, 2, true  as bool?, 3, 16),
            Tuple.Create( "19", true  as bool?, 2, false as bool?, 1, 19),
            Tuple.Create( "20", false as bool?, 2, false as bool?, 2, 19), //20
            Tuple.Create( "21", true  as bool?, 2, false as bool?, 3, 19),
            Tuple.Create( "22", false as bool?, 2, false as bool?, 1, 22),
            Tuple.Create( "23", true  as bool?, 2, false as bool?, 2, 22),
            Tuple.Create( "24", false as bool?, 2, false as bool?, 3, 22),
            Tuple.Create( "25", true  as bool?, 3, false as bool?, 1, 25),
            Tuple.Create( "26", false as bool?, 3, false as bool?, 2, 25),
            Tuple.Create( "27", true  as bool?, 3, false as bool?, 3, 25),
            Tuple.Create( "28", false as bool?, 3, false as bool?, 1, 28),
            Tuple.Create( "29", false as bool?, 3, false as bool?, 2, 28),
            Tuple.Create( "30", true  as bool?, 3, false as bool?, 3, 28), //30
            Tuple.Create( "31", false as bool?, 3, false as bool?, 1, 31),
            Tuple.Create( "32", true  as bool?, 3, false as bool?, 2, 31),
            Tuple.Create( "33", false as bool?, 3, false as bool?, 3, 31),
            Tuple.Create( "34", true  as bool?, 3, false as bool?, 1, 34),
            Tuple.Create( "35", false as bool?, 3, false as bool?, 2, 34),
            Tuple.Create( "36", true  as bool?, 3, false as bool?, 3, 34),
            Tuple.Create( "00", null  as bool?, 0, null  as bool?, 0, 0),  //38    
            
        };


        // FIRST SELECT MENU: USED TO SELECT WHAT TYPE OF BET THE USER WANTS

        public void BetSelect()
        {
            Console.Clear();
            Console.WriteLine("*^*^*^* WELCOME TO ROULETTE *^*^*^*");
            Console.WriteLine();
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

        public bool NumberBet()
        {
            int num = spin.Next(0, 37);
            bool check;
            int betVal = -5;
            Console.WriteLine("Please enter a number between 0-36, including 00.");
            do
            {

                check = true;

                try
                {
                    betVal = int.Parse(Console.ReadLine());
                    if (betVal > 36 || betVal < 0)
                    {
                        throw new FormatException();
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                    Console.Read();
                    check = false;
                }

            } while (check == false);

            Console.WriteLine(table[num].Item1);
            Console.WriteLine(betVal);

            if (betVal.ToString() == table[num].Item1)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EvenOddBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on either Even or Odd?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Even. Enter 2 for Odd.");

            var input = Console.ReadKey().Key;

            bool isEven = input == ConsoleKey.D1 ? isEven = true : isEven = false;
            bool evenCheck = (int.Parse(table[spin.Next(0, 37)].Item1) % 2 == 0);

            if (isEven == evenCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RedBlackBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on either Red or Black?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Red. Enter 2 for Black.");

            var input = Console.ReadKey().Key;

            bool isRed = input == ConsoleKey.D1 ? isRed = true : isRed = false;

            if (isRed == table[spin.Next(0, 37)].Item2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LowHighBet()
        {
            Console.Clear();
            Console.WriteLine("Wuuld you like to bet on either the Lower Half or the Higher Half?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Lower Half. Enter 2 for Higher Half.");

            var input = Console.ReadKey().Key;

            bool isLow = input == ConsoleKey.D1 ? isLow = true : isLow = false;

            if (isLow == table[spin.Next(0, 37)].Item4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DozensBet()
        {
            Console.Clear();
            Console.WriteLine("Would you like to bet on the First, Second, or Third Dozen?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for First Dozen. Enter 2 for Second Dozen. Enter 3 for Third Dozen.");

            string firstDozensBet = Console.ReadLine();
            int finalDozensBet = int.Parse(firstDozensBet);

            int input = int.Parse(Console.ReadLine());

            if (input == table[spin.Next(0, 37)].Item3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RowBet()
        {
            Console.Clear();
            Console.WriteLine("Which Row would you like to select?");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Row 1. Enter 2 for Row 2. Enter 3 for Row 3.");

            int input = int.Parse(Console.ReadLine());

            if (input == table[spin.Next(0, 37)].Item5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool StreetBet()
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

            int input = int.Parse(Console.ReadLine());

            if (input == table[spin.Next(0, 37)].Item6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DoubleStreetBet()
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

            int input = int.Parse(Console.ReadLine());

            if (input == 34)
            {
                Console.WriteLine("\nInvalid entry. Try again.");
                return false;
            }
            else if (input == table[spin.Next(0, 37)].Item6 || input == (table[spin.Next(0, 37)].Item6 + 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SplitBet()
        {
            Console.WriteLine("Enter the two numbers for the split.\n");

            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int num = spin.Next(0, 37);
            if (input + 1 == input2 || input - 1 == input2 || input - 3 == input2 || input + 3 == input2)
            {
                if (input == num || input2 == num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input");
                return false;
            }
        }

        public bool CornerBet()
        {
            Console.WriteLine("Enter the lowest then highest numbers of your split");

            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int num = spin.Next(0, 37);

            if (input > 32)
            {
                Console.WriteLine("\nInvalid Input");
                return false;
            }
            else if (input + 4 == input2)
            {
                int input3 = input + 1;
                int input4 = input2 - 1;
                if (input == num || input2 == num || input3 == num || input4 == num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input");
                return false;
            }
        }
    }
}
