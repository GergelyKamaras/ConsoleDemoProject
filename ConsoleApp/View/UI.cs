namespace ConsoleApp.View
{
    internal class UI
    {
        public const int NumberInputDigit = 1;
        public const int TextInputDigit = 2;

        public void Welcome()
        {
            Console.WriteLine("Welcome to this console application!");
            Console.WriteLine("Please follow the onscreen instructions!");
            Console.WriteLine("Press enter to continue!");
            Console.ReadLine();
            Console.Clear();
        }

        public int ChooseInputType()
        {
            Console.WriteLine("Please choose your next input's type by pressing the corresponding number:");
            Console.WriteLine($"{NumberInputDigit} => Number");
            Console.WriteLine($"{TextInputDigit} => Text");
            Console.Write("-> ");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }
    }
}
