using ConsoleApp.Model;
using ConsoleApp.Utility;

namespace ConsoleAppTests
{
    public class ValidatorTests
    {
        private Validator _validator;
        
        [SetUp]
        public void Setup()
        {
            _validator = new Validator();
        }

        [Test]
        public void ValidateNumber_PassMinNumber_ReturnsTrue()
        {
            Assert.That(_validator.ValidateNumber(Validator.MinNumber));
        }

        [Test]
        public void ValidateNumber_PassMaxNumber_ReturnsTrue()
        {
            Assert.That(_validator.ValidateNumber(Validator.MaxNumber));
        }
        
        [Test]
        public void ValidateNumber_PassRandomInRangeNumber_ReturnsTrue()
        {
            Assert.That(_validator.ValidateNumber(new Random().Next(Validator.MinNumber, Validator.MaxNumber)));
        }

        [Test]
        public void ValidateNumber_PassLowerThanMinNumber_ReturnsFalse()
        {
            Assert.That(_validator.ValidateNumber(Validator.MaxNumber));
        }

        [Test]
        public void ValidateNumber_PassLargerThanMaxNumber_ReturnsFalse()
        {
            Assert.That(!_validator.ValidateNumber(Validator.MaxNumber + 1));
        }

        [Test]
        public void ValidateText_PassMinLengthText_ReturnsTrue()
        {
            Assert.That(_validator.ValidateText(StringGenerator.GenerateString(Validator.TextMinLength)));
        }

        [Test]
        public void ValidateText_PassMaxLengthText_ReturnsTrue()
        {
            Assert.That(_validator.ValidateText(StringGenerator.GenerateString(Validator.TextMaxLength)));
        }

        [Test]
        public void ValidateText_PassRandomInRangeLengthText_ReturnsTrue()
        {
            Assert.That(_validator.ValidateText(StringGenerator.GenerateString(new Random().Next(Validator.TextMinLength, Validator.TextMaxLength))));
        }

        [Test]
        public void ValidateText_PassShorterThanMinLengthText_ReturnsFalse()
        {
            Assert.That(!_validator.ValidateText(StringGenerator.GenerateString(Validator.TextMinLength - 1)));
        }

        [Test]
        public void ValidateText_PassLongerThanMaxLengthText_ReturnsFalse()
        {
            Assert.That(!_validator.ValidateText(StringGenerator.GenerateString(Validator.TextMaxLength + 1)));
        }
    }
}