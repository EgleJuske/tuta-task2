using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;

            Console.WriteLine($"Sum is: {result}");
            Console.ReadKey();
        }
    }
}
