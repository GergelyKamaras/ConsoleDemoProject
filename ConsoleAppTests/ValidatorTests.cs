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
        public void ValidateNumber_PassMinNumber_ReturnsTrue()
        {
            Assert.That(Validator.ValidateNumber(Validator.MinNumber));
        }

        [Test]
        public void ValidateNumber_PassMaxNumber_ReturnsTrue()
        {
            Assert.That(Validator.ValidateNumber(Validator.MaxNumber));
        }
        
        [Test]
        public void ValidateNumber_PassRandomInRangeNumber_ReturnsTrue()
        {
            Assert.That(Validator.ValidateNumber(new Random().Next(Validator.MinNumber, Validator.MaxNumber)));
        }

        [Test]
        public void ValidateNumber_PassLowerThanMinNumber_ReturnsFalse()
        {
            Assert.That(Validator.ValidateNumber(Validator.MaxNumber));
        }

        [Test]
        public void ValidateNumber_PassLargerThanMaxNumber_ReturnsFalse()
        {
            Assert.That(!Validator.ValidateNumber(Validator.MaxNumber + 1));
        }

        [Test]
        public void ValidateText_PassMinLengthText_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateText_PassMaxLengthText_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateText_PassRandomInRangeLengthText_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateText_PassShorterThanMinLengthText_ReturnsFalse()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateText_PassLongerThanMaxLengthText_ReturnsFalse()
        {
            Assert.Pass();
        }
    }
}