using CommandLineApp.Builders;
using System;
using Xunit;

namespace CommandLineAppTest
{
    public class SameYearsBuilderTests
    {
        [Fact]
        public void ShouldBuiltDateReturnGoodValueForSameYears()
        {
            //Arrange
            var firstDate = new DateTime(2017, 1,1);
            var secondDate = new DateTime(2017, 2, 5);

            const string expedtedDateString = "01.01 - 05.02.2017";

            var builder = new SameYearsBuilder();

            //Act
            var actualOutput = builder.BuildDate(firstDate, secondDate);

            //Assert
            Assert.Equal(expedtedDateString, actualOutput);
        }
    }
}
