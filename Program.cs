using project_14_12_24.Classes;

namespace project_14_12_24
{
    internal class Program
    {
        public delegate void ShowMessage(string message);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                ShowMessage showMessage = new(DisplayMessage);
                showMessage("Hello World!"); 
                Console.WriteLine();
                showMessage.Invoke("Hello World!");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
