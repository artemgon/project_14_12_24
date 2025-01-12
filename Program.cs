using project_14_12_24.Classes;

namespace project_14_12_24
{
    public delegate bool CheckEven(int number);
    public delegate bool CheckOdd(int number);
    public delegate bool CheckPrime(int number);
    public delegate bool CheckFibonacci(int number);
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                CheckEven checkEven = IsEven;
                CheckOdd checkOdd = IsOdd;
                CheckPrime checkPrime = IsPrime;
                CheckFibonacci checkFibonacci = IsFibonacci;
                Console.WriteLine();
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine();
                Console.WriteLine("Is the number even? " + checkEven(number));
                Console.WriteLine();
                Console.WriteLine("Is the number odd? " + checkOdd(number));
                Console.WriteLine();
                Console.WriteLine("Is the number prime? " + checkPrime(number));
                Console.WriteLine();
                Console.WriteLine("Is the number a Fibonacci number? " + checkFibonacci(number));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }
        static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
    }
}
