using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class TwoIntegerEqualOrNot
    {
        public static void EqualOrNot()
        {
            Console.WriteLine("Enter First number.");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            int secondNumber=Convert.ToInt32(Console.ReadLine());
            if (firstNumber == secondNumber)
                Console.WriteLine("Both Integers are equal.");
            else
                Console.WriteLine("Both integers are not equal.");
        }
    }
}
