using ConsoleApp.Utility;

namespace ConsoleApp.Model
{
    public class ElementProcessor
    {
        public int ProcessInt(int num)
        {
            if (num % 2 == 0)
            {
                return num / 2;
            }
            else
            {
                return num * 2;
            }
        }

        public string ProcessString(string s)
        {
            if (s.Length < Config.OutputString.Length)
            {
                return Config.OutputString.Substring(0, s.Length);
            }

            return Config.OutputString;
        }

        public bool IsPrime(int num)
        {
            if (num == 2)
            {
                return true;
            }
            
            if (num <= 1 || num % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
