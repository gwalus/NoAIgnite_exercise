using CommandLineApp.Builders;
using System;
using Xunit;

namespace CommandLineAppTest
{
    public class SameMonthAndYearBuilderTests
    {
        [Fact]
        public void ShouldBuiltDateReturnGoodValueForSameMonthAndYear()
        {
            //Arrange
            var firstDate = new DateTime(2017, 1, 1);
            var secondDate = new DateTime(2017, 1, 5);

            const string expedtedDateString = "01 - 05.01.2017";

            var builder = new SameMonthAndYearBuilder();

            //Act
            var actualOutput = builder.BuildDate(firstDate, secondDate);

            //Assert
            Assert.Equal(expedtedDateString, actualOutput);
        }
    }
}
