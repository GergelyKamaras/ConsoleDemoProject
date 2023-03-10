using ConsoleApp.Model;
using ConsoleApp.View;

namespace ConsoleApp.Controller
{
    internal class AppController
    {
        private UI _ui;
        private DataCache _cache;
        private ElementProcessor _processor;
        private Validator _validator;

        public AppController()
        {
            _ui = new UI();
            _cache = new DataCache();
            _processor = new ElementProcessor();
            _validator = new Validator();
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

            ProcessElements();
        }

        private int HandleTypeChoice()
        {
            int input = 0;
            try
            {
                input = _ui.ChooseInputType();
                if (!_validator.ValidateTypeChoice(input))
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
                if (_validator.ValidateNumber(number))
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
                if (_validator.ValidateText(s))
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

        private void ProcessElements()
        {
            foreach (var element in _cache.Elements)
            {
                if (element is int)
                {
                    _processor.ProcessInt((int)element);
                }

                if (element is string)
                {
                    _processor.ProcessString((string)element);
                }
            }
        }
    }
}
