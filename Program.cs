using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int number1 = Convert.ToInt32(args[0]);
                int number2 = Convert.ToInt32(args[1]);
                int number3 = Convert.ToInt32(args[2]);
                int number4 = Convert.ToInt32(args[3]);
                int number5 = Convert.ToInt32(args[4]);
                int[] numbers = {number1,number2,number3,number4,number5};

                int sum = numbers.Sum();
                int max = numbers.Max();
                int min = numbers.Min();
                double average = numbers.Average();

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Max: " + max);
                Console.WriteLine("Min: " + min);
                Console.WriteLine("Average: " + average);
           
        }
    }
}
