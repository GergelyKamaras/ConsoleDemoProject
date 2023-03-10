namespace ConsoleApp.View
{
    internal class UI
    {
        public const int NumberInputDigit = 1;
        public const int TextInputDigit = 2;

        public void Welcome()
        {
            Console.WriteLine("Welcome to this Demo console application!");
            Console.WriteLine("After pressing enter, please follow the onscreen instructions");
            Console.ReadLine();
            Console.Clear();
        }

        public int ChooseInputType()
        {
            Console.Clear();
            Console.WriteLine("Please choose your next input's type by pressing the corresponding number:");
            Console.WriteLine($"{NumberInputDigit} => Number");
            Console.WriteLine($"{TextInputDigit} => Text");
            Console.Write("-> ");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }

        public int AskForNumber(int min, int max)
        {
            Console.WriteLine($"Please provide a number between {min} and {max}");
            Console.Write("-> ");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }

        public string AskForText(int minLength, int maxLength)
        {
            Console.WriteLine($"Please provide a text between length {minLength} and {maxLength}");
            Console.Write("-> ");
            return Console.ReadLine();
        }

        public void DisplayRemainingElements(int num)
        {
            Console.Clear();
            Console.WriteLine($"You need to provide {num} more elements\n");
        }

        public void ProcessDisplayWelcome()
        {
            Console.Clear();
            Console.WriteLine("Your processed input is as follows:\n");
        }

        public void DisplayProcessedNumber(int num, int processedNum, bool isPrime)
        {
            Console.Write($"{num} - {processedNum}");
            if (isPrime)
            {
                Console.WriteLine(" !prímszám");
            }
            else
            {
                Console.WriteLine();
            }
        }

        public void DisplayProcessedText(string text, string processedText)
        {
            Console.WriteLine($"{text} - {processedText}");
        }

        public void DisplayGoodbye()
        {
            Console.WriteLine("\nThank you for running me, have a nice day and press enter to exit the application!");
            Console.ReadLine();
        }
    }
}
