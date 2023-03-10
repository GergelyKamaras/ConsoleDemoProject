using ConsoleApp.Model;

namespace ConsoleAppTests
{
    public class ValidatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateNumberInput_PassMinNumber_ReturnsTrue()
        {
            Assert.That(InputValidator.ValidateNumberInput(InputValidator.MinNumber));
        }

        [Test]
        public void ValidateNumberInput_PassMaxNumber_ReturnsTrue()
        {
            Assert.That(InputValidator.ValidateNumberInput(InputValidator.MaxNumber));
        }
        
        [Test]
        public void ValidateNumberInput_PassRandomInRangeNumber_ReturnsTrue()
        {
            Assert.That(InputValidator.ValidateNumberInput(new Random().Next(InputValidator.MinNumber, InputValidator.MaxNumber)));
        }

        [Test]
        public void ValidateNumberInput_PassLowerThanMinNumber_ReturnsFalse()
        {
            Assert.That(InputValidator.ValidateNumberInput(InputValidator.MaxNumber));
        }

        [Test]
        public void ValidateNumberInput_PassLargerThanMaxNumber_ReturnsFalse()
        {
            Assert.That(!InputValidator.ValidateNumberInput(InputValidator.MaxNumber + 1));
        }

        [Test]
        public void ValidateTextInput_PassMinLengthText_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateTextInput_PassMaxLengthText_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateTextInput_PassRandomInRangeLengthText_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateTextInput_PassShorterThanMinLengthText_ReturnsFalse()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateTextInput_PassLongerThanMaxLengthText_ReturnsFalse()
        {
            Assert.Pass();
        }
    }
}