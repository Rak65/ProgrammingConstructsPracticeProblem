using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructsPractice
{
    public class ReverseWord
    {
        public static void RevWord()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;
            string reversedWord = "";

            while (length > 0)
            {
                length--;
                reversedWord += word[length];
            }
            Console.Write("Reversed Word: "+reversedWord);
        }
    }
}
