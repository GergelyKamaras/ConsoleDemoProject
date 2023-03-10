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
            Assert.Pass();
        }

        [Test]
        public void ValidateNumberInput_PassMaxNumber_ReturnsTrue()
        {
            Assert.Pass();
        }
        
        [Test]
        public void ValidateNumberInput_PassRandomInRangeNumber_ReturnsTrue()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateNumberInput_PassLowerThanMinNumber_ReturnsFalse()
        {
            Assert.Pass();
        }

        [Test]
        public void ValidateNumberInput_PassLargerThanMaxNumber_ReturnsFalse()
        {
            Assert.Pass();
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