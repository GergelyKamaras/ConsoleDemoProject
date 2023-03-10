using ConsoleApp.Model;

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
            Assert.Pass();
        }

        [Test]
        public void ProcessString_InputShorterThanMaxOutput_OutputLengthMatches()
        {
            Assert.Pass();
        }

        [Test]
        public void ProcessString_MaxLengthInput_ThrowsNoError()
        {
            Assert.Pass();
        }

        [Test]
        public void IsPrime_PrimeInput_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void IsPrime_NotPrimeInput_ReturnsFalse()
        {
            Assert.Pass();
        }
    }
}
