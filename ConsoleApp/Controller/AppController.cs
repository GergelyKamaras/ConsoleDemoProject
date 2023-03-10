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
                GetElement();
            }

            ProcessElements();
        }

        public void GetElement()
        {
            int type;
            try
            {
                type = HandleTypeChoice();
                _ui.DisplayRemainingElements(DataCache.MaxNumberOfElements - _cache.Elements.Count);
                if (type == UI.NumberInputDigit)
                {
                    HandleNumberInput();
                }
                else if (type == UI.TextInputDigit)
                {
                    HandleStringInput();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input, please provide a valid input!");
                Console.ReadLine();
            }
        }

        private int HandleTypeChoice()
        {
            
            int input = _ui.ChooseInputType();
            if (!_validator.ValidateTypeChoice(input))
            {
                throw new ArgumentException();
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
            _ui.ProcessDisplayWelcome();
            foreach (var element in _cache.Elements)
            {
                if (element is int)
                {
                    int processedNumber = _processor.ProcessInt((int)element);
                    bool isPrime = _processor.IsPrime((int)element);
                    _ui.DisplayProcessedNumber((int)element, processedNumber, isPrime);
                }

                if (element is string)
                {
                    string processedString = _processor.ProcessString((string)element);
                    _ui.DisplayProcessedText((string)element, processedString);
                }
            }

            _ui.DisplayGoodbye();
        }
    }
}
