using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class Vote
    {
        public static void Eligible()
        {
            Console.WriteLine("Enter your age.");
            int age=Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
                Console.WriteLine("You are eligible for vote.");
            else
                Console.WriteLine("You are not eligible for vote.");
        }
    }
}
