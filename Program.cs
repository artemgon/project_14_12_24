using project_14_12_24.Classes;

namespace project_14_12_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {

                Console.WriteLine();
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine();
                Console.WriteLine("Number is even: " + IsEven(number));
                Console.WriteLine();
                Console.WriteLine("Number is odd: " + IsOdd(number));
                Console.WriteLine();
                Console.WriteLine("Number is prime: " + IsPrime(number));
                Console.WriteLine();
                Console.WriteLine("Number is fibonacci: " + IsFibonacci(number));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static readonly Predicate<int> IsEven = number => number % 2 == 0;
        static readonly Predicate<int> IsOdd = number => number % 2 != 0;
        static readonly Predicate<int> IsPrime = number =>
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        };
        static readonly Predicate<int> IsFibonacci = number =>
        {
            if (number == 0) return true;
            int a = 0;
            int b = 1;
            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == number;
        };
    }
}
