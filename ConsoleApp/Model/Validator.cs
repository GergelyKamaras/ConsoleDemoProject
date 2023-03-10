using ConsoleApp.Utility;
using ConsoleApp.View;

namespace ConsoleApp.Model
{
    public class Validator
    {
        public bool ValidateTypeChoice(int num)
        {
            return (num == Config.TextInputDigit || num == Config.NumberInputDigit);
        }

        public bool ValidateNumber(int num)
        {
            return (Config.MinNumber <= num && num <= Config.MaxNumber);
        }

        public bool ValidateText(string text)
        {
            return (Config.TextMinLength <= text.Length && text.Length <= Config.TextMaxLength);
        }
    }
}
