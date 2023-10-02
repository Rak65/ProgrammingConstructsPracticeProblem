using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1. Check two integers are equal or not.");
                Console.WriteLine("2. Check number is Even or Odd.");
                Console.WriteLine("3. Check you are eligible for vote or not.");
                Console.WriteLine("4. Largest of three number.");
                Console.WriteLine("5. Candidate is eligible for admission or not.");
                Console.WriteLine("6. calculate the weekday name");
                Console.WriteLine("7. Calculate factorial.");
                Console.WriteLine("8. Flip Coin");
                Console.WriteLine("9. Reverse word");
                Console.WriteLine("10. Sum of first five natural number.");
                Console.WriteLine("11.Exit");
                string choice=Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TwoIntegerEqualOrNot.EqualOrNot();
                        break;
                    case "2":
                        EvenOrOdd.EvenOdd();
                        break;
                    case "3":
                        Vote.Eligible();
                        break;
                    case "4":
                        LargestOfThreeNum.LargestNum();
                        break;
                    case "5":
                        Admission.Eligibility();
                        break;
                    case "6":
                        WeekDayName.WeekDay();
                        break;
                    case "7":
                        Factorial.Fact();
                        break;
                    case "8":
                        FlipCoin.Coin();
                        break;
                    case "9":
                        ReverseWord.RevWord();
                        break;
                    case "10":
                        SumFirst5NaturalNum.Sum();
                        break;
                    case "11":
                        isRunning = false;
                        break;
                    default: Console.WriteLine("Try again ----");
                        break;
                }
            }
        }
    }
}
