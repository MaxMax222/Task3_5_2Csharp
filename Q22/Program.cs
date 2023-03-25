using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int len;
            Console.Write("enter the length of the array: ->");
            len = int.Parse(Console.ReadLine());
            numbers = new int[len];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"enter the {i + 1} number: ->");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine($"the sorted array: {string.Join(",", numbers)}");
        }
    }
}
