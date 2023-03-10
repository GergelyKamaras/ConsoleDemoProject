using ConsoleApp.Model;
using ConsoleApp.View;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();

            ui.Welcome();
            try
            {
                int input = ui.ChooseInputType();
                if (!InputValidator.ValidateInputTypeChoice(input))
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please choose again!");
            }
        }
    }
}