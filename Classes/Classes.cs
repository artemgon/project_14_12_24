
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace project_14_12_24.Classes
{
    public class CreditCard
    {
        public string? CardNumber { get; set; }
        public string? HolderSNP { get; set; }
        public string? ExpirationDate { get; set; }
        private string? PIN;
        public string? CreditLimit { get; set; }
        public float Balance { get; set; }
        public string? Pin
        {
            private get { return PIN; }
            set
            {
                if (value != null && value.Length == 4)
                {
                    PIN = value;
                }
                else
                {
                    throw new Exception("PIN must be 4 digits long");
                }
            }
        }
        public event Action<float>? Replenish;
        public event Action<float>? Withdraw;
        public event Action<string>? CreditUsageStart;
        public event Predicate<int>? LimitReached;
        public event Action<string>? ChangePin;
        public CreditCard()
        {
            CardNumber = "";
            HolderSNP = "";
            ExpirationDate = "";
            Pin = "";
            CreditLimit = "";
            Balance = 0;
        }
        public CreditCard(string cardNumber, string holderSNP, string expirationDate, string pin, string creditLimit, float balance)
        {
            CardNumber = cardNumber;
            HolderSNP = holderSNP;
            ExpirationDate = expirationDate;
            Pin = pin;
            CreditLimit = creditLimit;
            Balance = balance;
        }
        public void ReplenishBalance(float amount)
        {
            Balance += amount;
            Replenish?.Invoke(amount);
        }
        public void WithdrawBalance(float amount)
        {
            Balance -= amount;
            Withdraw?.Invoke(amount);
        }
        public void StartCreditUsage(string message)
        {
            CreditUsageStart?.Invoke(message);
        }
        public bool IsLimitReached(int amount)
        {
            return LimitReached?.Invoke(amount) ?? false;
        }
        public void ChangePinCode(string newPin)
        {
            Pin = newPin;
            ChangePin?.Invoke(newPin);
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Credit card information:");
            Console.WriteLine($"Card number: {CardNumber}");
            Console.WriteLine($"Holder SNP: {HolderSNP}");
            Console.WriteLine($"Expiration date: {ExpirationDate}");
            Console.WriteLine($"PIN: {PIN}");
            Console.WriteLine($"Credit limit: {CreditLimit}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine();
        }
    }
}
