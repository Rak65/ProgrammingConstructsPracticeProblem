using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class LargestOfThreeNum
    {
        public static void LargestNum()
        {
            Console.WriteLine("Enter First number.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number.");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
                Console.WriteLine(firstNumber + " is greatest number.");
            else if (secondNumber > thirdNumber && secondNumber > firstNumber)
                Console.WriteLine(secondNumber + " is greatest number");
            else
                Console.WriteLine(thirdNumber + " is greatest number");
        }
    }
}
