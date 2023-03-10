namespace ConsoleApp.Model
{
    public class ElementProcessor
    {
        public const string OutputString = "Making an impact that matters –Deloitte";
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
            if (s.Length < OutputString.Length)
            {
                return OutputString.Substring(0, s.Length);
            }

            return OutputString;
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
