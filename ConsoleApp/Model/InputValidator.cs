using ConsoleApp.View;

namespace ConsoleApp.Model
{
    internal static class InputValidator
    {
        public static bool ValidateInputTypeChoice(int num)
        {
            return (num == UI.NumberInputDigit || num == UI.TextInputDigit);
        }
    }
}
