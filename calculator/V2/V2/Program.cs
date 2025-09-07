using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic calculator.");
            Console.WriteLine("Wich opretion do you want?");
            Console.WriteLine("+\n-\n*\n/");
            string opretion = Console.ReadLine();
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (opretion == "+")
            {
                double res = sum(num1, num2);
                Console.WriteLine("the result is "+ res);
            }
            else if (opretion == "-")
            {
                double res = Sub(num1, num2);
                Console.WriteLine("the result is " + res);
            }
            else if (opretion == "*")
            {
                double res = multiply(num1, num2);
                Console.WriteLine("the result is " + res);
            }
            else if (opretion == "/")
            {
                double res = Divide(num1, num2);
                Console.WriteLine("the result is " + res);
            }
        }
        static double sum(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        static double Sub(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        static double multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        static double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
