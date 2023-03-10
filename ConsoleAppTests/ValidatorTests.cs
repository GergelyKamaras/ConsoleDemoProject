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
            Assert.That(_validator.ValidateNumber(Config.MinNumber));
        }

        [Test]
        public void ValidateNumber_PassMaxNumber_ReturnsTrue()
        {
            Assert.That(_validator.ValidateNumber(Config.MaxNumber));
        }
        
        [Test]
        public void ValidateNumber_PassRandomInRangeNumber_ReturnsTrue()
        {
            Assert.That(_validator.ValidateNumber(new Random().Next(Config.MinNumber, Config.MaxNumber)));
        }

        [Test]
        public void ValidateNumber_PassLowerThanMinNumber_ReturnsFalse()
        {
            Assert.That(_validator.ValidateNumber(Config.MaxNumber));
        }

        [Test]
        public void ValidateNumber_PassLargerThanMaxNumber_ReturnsFalse()
        {
            Assert.That(!_validator.ValidateNumber(Config.MaxNumber + 1));
        }

        [Test]
        public void ValidateText_PassMinLengthText_ReturnsTrue()
        {
            Assert.That(_validator.ValidateText(StringGenerator.GenerateString(Config.TextMinLength)));
        }

        [Test]
        public void ValidateText_PassMaxLengthText_ReturnsTrue()
        {
            Assert.That(_validator.ValidateText(StringGenerator.GenerateString(Config.TextMaxLength)));
        }

        [Test]
        public void ValidateText_PassRandomInRangeLengthText_ReturnsTrue()
        {
            Assert.That(_validator.ValidateText(StringGenerator.GenerateString(new Random().Next(Config.TextMinLength, Config.TextMaxLength))));
        }

        [Test]
        public void ValidateText_PassShorterThanMinLengthText_ReturnsFalse()
        {
            Assert.That(!_validator.ValidateText(StringGenerator.GenerateString(Config.TextMinLength - 1)));
        }

        [Test]
        public void ValidateText_PassLongerThanMaxLengthText_ReturnsFalse()
        {
            Assert.That(!_validator.ValidateText(StringGenerator.GenerateString(Config.TextMaxLength + 1)));
        }
    }
}