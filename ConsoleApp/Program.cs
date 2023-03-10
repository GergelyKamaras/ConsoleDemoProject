using ConsoleApp.Controller;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppController controller = new AppController();
            controller.Start();
        }
    }
}