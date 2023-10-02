using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class SumFirst5NaturalNum
    {
        public static void Sum()
        {
            int n = 5; 
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("The sum of the first " + n + " natural numbers is: " + sum);

        }
    }
}
