using project_14_12_24.Classes;
using System.Text;

namespace project_14_12_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Action showCurrentTime = ShowCurrentTime;
                Action showCurrentDate = ShowCurrentDate;
                Action showCurrentDayOfWeek = ShowCurrentDayOfWeek;
                showCurrentTime();
                showCurrentDate();
                showCurrentDayOfWeek();
                Console.WriteLine();
                Predicate<double> isValidSide = IsValidSide;
                double a = 3, b = 4, c = 5;
                if (isValidSide(a) && isValidSide(b) && isValidSide(c))
                {
                    Func<double, double, double, double> calculateTriangleArea = CalculateTriangleArea;
                    Console.WriteLine("Triangle area: " + calculateTriangleArea(a, b, c));
                }
                else
                {
                    Console.WriteLine("Invalid side length");
                }
                Console.WriteLine();   
                Func<double, double, double> calculateRectangleArea = CalculateRectangleArea;
                a = 5;
                b = 10;
                Console.WriteLine("Rectangle area: " + calculateRectangleArea(a, b));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ShowCurrentTime()
        {
            Console.WriteLine("Current time: " + DateTime.Now.ToString("HH:mm:ss"));
        }
        static void ShowCurrentDate()
        {
            Console.WriteLine("Current date: " + DateTime.Now.ToString("dd.MM.yyyy"));
        }
        static void ShowCurrentDayOfWeek()
        {
            Console.WriteLine("Current day of week: " + DateTime.Now.ToString("dddd"));
        }
        static bool IsValidSide(double side)
        {
            return side > 0;
        }
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (!IsValidSide(a) || !IsValidSide(b) || !IsValidSide(c))
            {
                throw new ArgumentException("Invalid side length");
            }
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static double CalculateRectangleArea(double a, double b)
        {
            if (!IsValidSide(a) || !IsValidSide(b))
            {
                throw new ArgumentException("Invalid side length");
            }
            return a * b;
        }
    }
}
