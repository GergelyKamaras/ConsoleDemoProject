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
            }

            return input;
        }

        private void HandleNumberInput()
        {

        }

        private void HandleStringInput()
        {

        }
    }
}
