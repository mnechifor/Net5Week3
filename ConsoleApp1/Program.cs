using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SumOfEvenNumbersInArray();
            // FindSumInArray(8);

            int factorial = FactorialRecursiv(5);

            Console.WriteLine(factorial);
        }

        private static int FactorialRecursiv(int nr)
        {
            if (nr == 1)
            {
                return 1;
            }

            return nr * FactorialRecursiv(nr - 1);
        }

        private static int FactorialIterativ(int nr)
        {
            int fact = 1;
            for (int i = 1; i <= nr ;i++)
            {
                fact = fact * i;
            }

            return fact;
        }

        private static void FindSumInArray(int sumToFind)
        {
            int[] arr = new Int32[] { 2, 4, 5, 6, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == sumToFind)
                    {
                        Console.WriteLine($"{arr[i]}+{arr[j]}={sumToFind}");
                    }
                }
            }
        }

        private static void SumOfEvenNumbersInArray()
        {
            int[] arr = new Int32[] { 2, 4, 5, 6 };
            int sum = 0;

            foreach (var number in arr)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
