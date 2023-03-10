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
            throw new NotImplementedException();
        }
    }
}
