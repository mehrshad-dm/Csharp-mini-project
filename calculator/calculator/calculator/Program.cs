using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to this app.");
            Console.Write("enter your first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter your second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("the result is: ");
            Console.WriteLine(number1 + number2);
        }
    }
}
