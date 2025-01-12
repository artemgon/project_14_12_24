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
                CreditCard creditCard = new("1234 5678 9012 3456", "John Doe", "12/24", "1234", "1000", 0);
                creditCard.Display();
                Console.WriteLine();
                Console.WriteLine("Enter the amount to replenish the balance:");
                int amount = int.Parse(Console.ReadLine() ?? "");
                creditCard.ReplenishBalance(amount);
                Console.WriteLine();
                Console.WriteLine("Enter the amount to withdraw from the balance:");
                amount = int.Parse(Console.ReadLine() ?? "");
                creditCard.WithdrawBalance(amount);
                Console.WriteLine();
                Console.WriteLine("Enter the date of the start of credit usage:");
                string date = Console.ReadLine() ?? "";
                Console.WriteLine();
                Console.WriteLine("Enter the amount to check if the limit is reached:");
                amount = int.Parse(Console.ReadLine() ?? "");
                Console.WriteLine(creditCard.IsLimitReached(amount));
                Console.WriteLine();
                Console.WriteLine("Enter the new PIN:");
                string pin = Console.ReadLine() ?? "";
                creditCard.ChangePinCode(pin);
                Console.WriteLine();
                creditCard.Display();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
