using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class FlipCoin
    {
        public static void Coin()
        {
            int headsCount = 0;
            int tailsCount = 0;
            int totalFlips = 0;
            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                int flipResult = random.Next(2);

                if (flipResult == 0)
                {
                    headsCount++;
                    Console.WriteLine("Heads!");
                }
                else
                {
                    tailsCount++;
                    Console.WriteLine("Tails!");
                }

                totalFlips++;
            }

            Console.WriteLine("\nGame over!");
            Console.WriteLine("Total flips: " + totalFlips);
            Console.WriteLine("Heads count: " + headsCount);
            Console.WriteLine("Tails count: " + tailsCount);

            if (headsCount == 20)
                Console.WriteLine("Heads won!");
            else
                Console.WriteLine("Tails won!");
        }
    }
}
