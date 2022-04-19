using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number: ");
            string line = Console.ReadLine();
            int number = 0;
            bool result = Int32.TryParse(line, out number);
            if (result)
            {
                Console.WriteLine("Input Number = " + number);
                int sum = 0;

                while (number > 0)
                {
                    int r = number % 10;
                    sum += r;
                    number /= 10;
                }

                Console.WriteLine("sum of digits = " + sum);
            }
            else
            {
                Console.WriteLine("invalid Input ");
            }

            Console.Read();

        }
    }
}
