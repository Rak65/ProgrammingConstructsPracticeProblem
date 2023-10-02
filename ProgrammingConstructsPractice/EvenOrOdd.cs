using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class EvenOrOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter the number.");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd Number.");
        }
    }
}
