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

            //int factorial = FactorialRecursiv(5);

            // Console.WriteLine(factorial);

            // Console.WriteLine(ArrayContainsDuplicates());

            //Console.WriteLine(SumOfDigitsIterative(123));
            //Console.WriteLine(SumOfDigitsRecursive(123));

            Dictionary<char, int> dictionar = new Dictionary<char, int>();
            dictionar.Add('x', 10);

            if(!dictionar.Keys.Contains('x'))
            {

            }

           // Majority();
        }

        private static void Majority()
        {
            int[] sir = new int[] { 5, 3, 2, 5, 5, 5, 5, 2, 4, 8 };
            int numar, contor;
            numar = contor = 0;
            for (int i = 0; i < sir.Length; i++)
            {
                for (int j = i; j < sir.Length; j++)
                {
                    if (sir[i] == sir[j])
                    {
                        contor++;
                    }
                }

                if (contor >= sir.Length / 2)
                {
                    numar = sir[i];
                }
                contor = 0;
            }
            Console.WriteLine("Numarul " + numar + " este majoritar");
        }

        private static int SumOfDigitsIterative(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        static int SumOfDigitsRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return (n % 10 + SumOfDigitsRecursive(n / 10));
        }

        private static bool ArrayContainsDuplicates()
        {
            int[] arr = new Int32[] { 2, 2, 5, 6, 3 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return true;
                    }
                }
            }

            return false;
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
