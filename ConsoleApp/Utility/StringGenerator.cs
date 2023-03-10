namespace ConsoleApp.Utility
{
    public static class StringGenerator
    {
        private const int _ascciMin = 0;
        private const int _asciiMax = 126;
        
        public static string GenerateString(int length)
        {
            Random random = new Random();
            string outString = "";

            for (int i = 0; i < length; i++)
            {
                outString += Convert.ToChar(random.Next(_ascciMin, _asciiMax));
            }

            return outString;
        }
    }
}
