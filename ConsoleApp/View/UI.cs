﻿namespace ConsoleApp.View
{
    internal class UI
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to this console application!");
            Console.WriteLine("Please follow the onscreen instructions!");
            Console.WriteLine("Press enter to continue!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}