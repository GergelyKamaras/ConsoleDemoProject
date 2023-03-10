using ConsoleApp.View;

namespace ConsoleApp.Model
{
    public static class InputValidator
    {
        public const int MinNumber = 10;
        public const int MaxNumber = 9999;
        public const int TextMinLength = 5;
        public const int TextMaxLength = 45;
        
        public static bool ValidateInputTypeChoice(int num)
        {
            return (num == UI.NumberInputDigit || num == UI.TextInputDigit);
        }

        public static bool ValidateNumberInput(int num)
        {
            return (MinNumber <= num && num <= MaxNumber);
        }

        public static bool ValidateTextInput(string text)
        {
            throw new NotImplementedException();
        }
    }
}
