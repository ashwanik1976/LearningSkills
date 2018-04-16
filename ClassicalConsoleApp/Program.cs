using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetSendHighestDigitInGivenNumber();
            Console.Read();
        }

        private static void GetSendHighestDigitInGivenNumber()
        {
            int num, k = 0; int a = 0, b = 0, tmp = 0; num = 975846;
            int[] arr = new int[6];
            Array.BinarySearch(arr, 8);
            while (num > 0)
            {
                tmp = num % 10;
                num = num / 10;
                arr[k] = tmp;
                k++;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
            }
            Console.WriteLine("Second largest number is b={0}", arr[1]);
        }
    }
}
