namespace ConsoleApp.Utility
{
    public static class StringGenerator
    {
        private const int AsciiMin = 0;
        private const int AsciiMax = 126;
        
        public static string GenerateString(int length)
        {
            Random random = new Random();
            string outString = "";

            for (int i = 0; i < length; i++)
            {
                outString += Convert.ToChar(random.Next(AsciiMin, AsciiMax));
            }

            return outString;
        }
    }
}
