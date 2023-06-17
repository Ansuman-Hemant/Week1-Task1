using System;
namespace Varise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operation: ");
            string op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine("The sum of {0} and {1} is {2} ", num1, num2, num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine("The difference between {0} and {1} is {2}", num1, num2, num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, num1 * num2);
            }
            else if ((op == "/") || (op == "%"))
            {
                if (num2 != 0)
                {
                    Console.WriteLine("The quotient of {0} and {1} is {2}", num1, num2, num1 / num2);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }

            Console.ReadLine();

        }
    }

}