using CommandLineApp.Validators;
using System;
using Xunit;

namespace CommandLineAppTest
{
    public class DateValidatorTests
    {
        [Fact]
        public void IsInputDataTimeType()
        {
            //Arrange
            DateTime date = DateTime.Now;
            const bool expectedOutput = true;

            //Act
            var actualOutput = DateValidator.IsDate(date);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Theory]
        [InlineData("01.06.2017", true, "06.01.2017")] // DateTime first is month
        [InlineData("01062017", false, "01.01.0001")]
        public void IsInputArgumentDateTimeValid(string expectedStringDate, bool expectedIsValid, DateTime expectedDateTime)
        {
            //Act
            var actualIsValid = DateValidator.IsValid(expectedStringDate, out DateTime actualDate);

            //Assert
            Assert.Equal(expectedIsValid, actualIsValid);
            Assert.Equal(expectedDateTime, actualDate);
        }

        [Fact]
        public void AreDatesTheSame()
        {
            //Arrange
            var firstDate = new DateTime(2021, 5, 14);
            var secondDate = new DateTime(2021, 5, 14);
            const bool expectedOutput = true;

            //Act
            var actualOutput = DateValidator.IsSame(firstDate, secondDate);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void IsFirstDateGreaterThanSecond()
        {
            //Arrange
            var firstDate = new DateTime(2021, 5, 14);
            var secondDate = new DateTime(2021, 5, 7);
            const bool expectedOutput = true;

            //Act
            var actualOutput = DateValidator.IsGreater(firstDate, secondDate);

            //Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
