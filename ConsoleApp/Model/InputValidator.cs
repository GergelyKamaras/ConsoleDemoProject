using ConsoleApp.View;

namespace ConsoleApp.Model
{
    public static class Validator
    {
        public const int MinNumber = 10;
        public const int MaxNumber = 9999;
        public const int TextMinLength = 5;
        public const int TextMaxLength = 45;
        
        public static bool ValidateTypeChoice(int num)
        {
            return (num == UI.TextInputDigit || num == UI.NumberInputDigit);
        }

        public static bool ValidateNumber(int num)
        {
            return (MinNumber <= num && num <= MaxNumber);
        }

        public static bool ValidateText(string text)
        {
            return (TextMinLength <= text.Length && text.Length <= TextMaxLength);
        }
    }
}
