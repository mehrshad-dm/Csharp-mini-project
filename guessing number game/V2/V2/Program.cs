using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "hi";
            string guess = "";
            int times = 7;
            while (times > 0)
            {
                Console.WriteLine("you have "+times+" chance");
                Console.Write("enter your guess: ");
                guess = Console.ReadLine();
                times--;
                if (guess == secretWord)
                {
                    Console.WriteLine("you win!");
                    break;
                }
                else
                {
                    Console.WriteLine("you lose, try again, you have "+ times + " yet.\n");
                }
            }
        }
    }
}
