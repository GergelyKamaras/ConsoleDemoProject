using ConsoleApp.Model;
using ConsoleApp.View;

namespace ConsoleApp.Controller
{
    internal class AppController
    {
        private UI _ui;
        private DataCache _cache;

        public AppController()
        {
            _ui = new UI();
            _cache = new DataCache();
        }

        public void Start()
        {
            _ui.Welcome();

            while (_cache.Elements.Count < DataCache.MaxNumberOfElements)
            {
                int type = HandleTypeChoice();
                _ui.DisplayRemainingElements(DataCache.MaxNumberOfElements - _cache.Elements.Count);
                if (type == UI.NumberInputDigit)
                {
                    HandleNumberInput();
                }
                else
                {
                    HandleStringInput();
                }
            }
        }

        private int HandleTypeChoice()
        {
            int input = 0;
            try
            {
                input = _ui.ChooseInputType();
                if (!Validator.ValidateTypeChoice(input))
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please choose again!");
                Console.ReadLine();
            }

            return input;
        }

        private void HandleNumberInput()
        {
            try
            {
                int number = _ui.AskForNumber(Validator.MinNumber, Validator.MaxNumber);
                if (Validator.ValidateNumber(number))
                {
                    _cache.Elements.Add(number);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please choose again!");
                Console.ReadLine();
            }

        }

        private void HandleStringInput()
        {
            try
            {
                string s = _ui.AskForText(Validator.TextMinLength, Validator.TextMaxLength);
                if (Validator.ValidateText(s))
                {
                    _cache.Elements.Add(s);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please choose again!");
                Console.ReadLine();
            }

        }
    }
}
