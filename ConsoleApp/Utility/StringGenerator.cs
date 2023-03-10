namespace ConsoleApp.Utility
{
    public static class StringGenerator
    {
        public static string GenerateString(int length)
        {
            Random random = new Random();
            string outString = "";

            for (int i = 0; i < length; i++)
            {
                outString += Convert.ToChar(random.Next(Config.AsciiMin, Config.AsciiMax));
            }

            return outString;
        }
    }
}
