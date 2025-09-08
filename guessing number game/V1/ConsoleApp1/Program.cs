using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "hi";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();
                if (guess == secretWord)
                {
                    Console.WriteLine("You win!");
                    break;
                } 
                else 
                {
                    Console.WriteLine("You lose, Try again");
                }
            }
        }
    }
}
