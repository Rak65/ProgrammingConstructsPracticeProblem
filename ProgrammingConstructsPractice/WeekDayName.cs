using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class WeekDayName
    {
        public static void WeekDay()
        {
            Console.Write("Enter a weekday number (1-7): ");
            int weekdayNumber = int.Parse(Console.ReadLine());

            string weekdayName;

            switch (weekdayNumber)
            {
                case 1:
                    weekdayName = "Sunday";
                    break;
                case 2:
                    weekdayName = "Monday";
                    break;
                case 3:
                    weekdayName = "Tuesday";
                    break;
                case 4:
                    weekdayName = "Wednesday";
                    break;
                case 5:
                    weekdayName = "Thursday";
                    break;
                case 6:
                    weekdayName = "Friday";
                    break;
                case 7:
                    weekdayName = "Saturday";
                    break;
                default:
                    weekdayName = "Invalid input";
                    break;
            }

            Console.WriteLine("The weekday is: " + weekdayName);
        }
    }
}
