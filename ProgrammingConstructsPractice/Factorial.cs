using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class Factorial
    {
        public static void Fact()
        {
            Console.WriteLine("Enter the number.");
            int number= int.Parse(Console.ReadLine());
            int f = 1;
            for(int i = number; i>=1; i--)
            {
                f *= i;
            }
            Console.WriteLine("Factorial of " + number + " : " + f);
        }
    }
}
