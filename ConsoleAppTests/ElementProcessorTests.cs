using ConsoleApp.Model;
using ConsoleApp.Utility;

namespace ConsoleAppTests
{
    internal class ElementProcessorTests
    {
        private ElementProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new ElementProcessor();
        }

        [Test]
        public void ProcessInt_EvenNumber_ReturnsHalf()
        {
            int testNum;
            Random random = new Random();
            
            do
            {
                testNum = random.Next();
            } while (testNum % 2 != 0);
            
            Assert.That(testNum / 2 == _processor.ProcessInt(testNum));
        }

        [Test]
        public void ProcessInt_OddNumber_ReturnsDouble()
        {
            int testNum;
            Random random = new Random();

            do
            {
                testNum = random.Next();
            } while (testNum % 2 == 0);

            Assert.That(testNum * 2 == _processor.ProcessInt(testNum));
        }

        [Test]
        public void ProcessString_MinLengthInput_OutputLengthMatches()
        {
            string input = StringGenerator.GenerateString(Config.TextMinLength);
            string output = _processor.ProcessString(input);
            Assert.That(input.Length == output.Length);
        }

        [Test]
        public void ProcessString_InputLengthMatchesMaxOutput_OutputLengthMatches()
        {
            string input = StringGenerator.GenerateString(Config.OutputString.Length);
            string output = _processor.ProcessString(input);
            Assert.That(input.Length == output.Length);
        }

        [Test]
        public void ProcessString_MaxLengthInput_ThrowsNoError()
        {
            string input = StringGenerator.GenerateString(Config.TextMaxLength);
            Assert.DoesNotThrow(() => _processor.ProcessString(input));
            
        }

        [Test]
        public void IsPrime_PrimeInput_ReturnsTrue()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_processor.IsPrime(2));
                Assert.That(_processor.IsPrime(13));
                Assert.That(_processor.IsPrime(29));
                Assert.That(_processor.IsPrime(73));
                Assert.That(_processor.IsPrime(97));
            });
        }

        [Test]
        public void IsPrime_NotPrimeInput_ReturnsFalse()
        {
            Assert.Multiple(() =>
            {
                Assert.That(!_processor.IsPrime(-1));
                Assert.That(!_processor.IsPrime(1));
                Assert.That(!_processor.IsPrime(80));
                Assert.That(!_processor.IsPrime(2562));
                Assert.That(!_processor.IsPrime(15));
                Assert.That(!_processor.IsPrime(81));
            });
        }
    }
}
