using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Enter the Number 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number 2");
            int number2 = int.Parse(Console.ReadLine());
            int addresult = number1 + number2;
            int diffresult= Math.Abs(number1 - number2);
            int prodresult = number1 * number2;
            Console.WriteLine("Addition of Two number is " + addresult);
            Console.WriteLine("Sum of {0} and {1} is {2}", number1, number2, addresult);
            Console.WriteLine("difference between {0} and {1} is {2}", number1, number2, diffresult);
            Console.WriteLine("Product of {0} and {1} is {2}", number1, number2, prodresult);

            Console.WriteLine("Hello World");






        }
    }
}
