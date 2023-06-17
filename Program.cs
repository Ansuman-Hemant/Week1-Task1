using System;

namespace Varise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int trail = 0;
            int d = 5;

            while (n >= d)
            {
                trail += n / d;
                d *= 5;
            }

            Console.WriteLine("Number of trailing zeroes in {0}! is {1}", n, trail);
            Console.ReadLine();
        }
    }
}
