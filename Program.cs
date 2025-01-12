using project_14_12_24.Classes;

namespace project_14_12_24
{
    internal class Program
    {
        public delegate int Sum(int a, int b);
        public delegate int Sub(int a, int b);
        public delegate int Mul(int a, int b);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Sum sum = Add;
                Sub sub = Subtract;
                Mul mul = Multiply;
                Console.WriteLine("Enter two numbers:");
                int a = int.Parse(Console.ReadLine() ?? "");
                int b = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine();
                Console.WriteLine("Sum:");
                Console.WriteLine(sum.Invoke(a, b));
                Console.WriteLine();
                Console.WriteLine("Subtract:");
                Console.WriteLine(sub.Invoke(a, b));
                Console.WriteLine();
                Console.WriteLine("Multiply:");
                Console.WriteLine(mul.Invoke(a, b));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
