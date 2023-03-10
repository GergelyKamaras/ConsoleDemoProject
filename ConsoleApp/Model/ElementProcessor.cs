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
            throw new NotImplementedException();
        }

        public bool IsPrime(int num)
        {
            throw new NotImplementedException();
        }
    }
}
