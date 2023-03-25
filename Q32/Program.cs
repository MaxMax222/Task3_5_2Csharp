using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q32
{
    class Program
    {
        static bool ZigZag(int[] arr)
        {
            bool checkOption1 = false, checkOption2 = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    checkOption1 = arr[i] < arr[i + 1]; 
                }
                else
                {
                    checkOption1 = arr[i] > arr[i + 1];
                }
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    checkOption2 = arr[i] > arr[i + 1];
                }
                else
                {
                    checkOption2 = arr[i] < arr[i + 1];
                }
            }
            return checkOption1 || checkOption2;
        }
        static void Main(string[] args)
        {

            int[] arr1 = { 8, 70, 5, 20, 6, 40, 3 };
            int[] arr2 = { 80, 6, 40, 30, 50, 20 };
            if (ZigZag(arr1))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (ZigZag(arr2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
