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
            double num;
            Console.WriteLine("Welcome to the program to determine whether a number is postive or negative.");
            Console.Write("Enter a number: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Your number is postive.");
            }
            else if (num == 0)
            {
                Console.WriteLine("Your number is zero.");
            }
            else
            {
                Console.WriteLine("Your number is negative.");
            }
        }
    }
}
