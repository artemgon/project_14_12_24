using project_14_12_24.Classes;
using System.Data;

namespace project_14_12_24
{
    public delegate bool FindEven(int number);
    public delegate bool FindOdd(int number);
    public delegate bool FindPrime(int number);
    public delegate bool FindFibonacci(int number);
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.WriteLine("Even numbers:");
                int[] evenNumbers = GetEvenNumbers(numbers, IsEven);
                foreach (var number in evenNumbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Odd numbers:");
                int[] oddNumbers = GetOddNumbers(numbers, IsOdd);
                foreach (var number in oddNumbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Prime numbers:");
                int[] primeNumbers = GetPrimeNumbers(numbers, IsPrime);
                foreach (var number in primeNumbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Fibonacci numbers:");
                int[] fibonacciNumbers = GetFibonacciNumbers(numbers, IsFibonacci);
                foreach (var number in fibonacciNumbers)
                {
                    Console.Write(number + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int[] GetEvenNumbers(int[] numbers, FindEven findEven)
        {
            List<int> evenNumbers = new();
            foreach (var number in numbers)
            {
                if (findEven(number))
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers.ToArray();
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        public static int[] GetOddNumbers(int[] numbers, FindOdd findOdd)
        {
            List<int> oddNumbers = new();
            foreach (var number in numbers)
            {
                if (findOdd(number))
                {
                    oddNumbers.Add(number);
                }
            }
            return oddNumbers.ToArray();
        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int[] GetPrimeNumbers(int[] numbers, FindPrime findPrime)
        {
            List<int> primeNumbers = new();
            foreach (var number in numbers)
            {
                if (findPrime(number))
                {
                    primeNumbers.Add(number);
                }
            }
            return primeNumbers.ToArray();
        }
        public static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;
            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == number;
        }
        public static int[] GetFibonacciNumbers(int[] numbers, FindFibonacci findFibonacci)
        {
            List<int> fibonacciNumbers = new();
            foreach (var number in numbers)
            {
                if (findFibonacci(number))
                {
                    fibonacciNumbers.Add(number);
                }
            }
            return fibonacciNumbers.ToArray();
        }
    }
}
