using ConsoleApp.View;

namespace ConsoleApp.Model
{
    public class Validator
    {
        public const int MinNumber = 10;
        public const int MaxNumber = 9999;
        public const int TextMinLength = 5;
        public const int TextMaxLength = 45;
        
        public bool ValidateTypeChoice(int num)
        {
            return (num == Ui.TextInputDigit || num == Ui.NumberInputDigit);
        }

        public bool ValidateNumber(int num)
        {
            return (MinNumber <= num && num <= MaxNumber);
        }

        public bool ValidateText(string text)
        {
            return (TextMinLength <= text.Length && text.Length <= TextMaxLength);
        }
    }
}
