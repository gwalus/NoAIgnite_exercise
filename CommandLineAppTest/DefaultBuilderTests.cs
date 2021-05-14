using CommandLineApp.Builders;
using System;
using Xunit;

namespace CommandLineAppTest
{
    public class DefaultBuilderTests
    {
        [Fact]
        public void ShouldBuiltDateReturnGoodValueForDefault()
        {
            //Arrange
            var firstDate = new DateTime(2000, 1, 1);
            var secondDate = new DateTime(2021, 5, 14);

            const string expedtedDateString = "01.01.2000 - 14.05.2021";

            var builder = new DefaultBuilder();

            //Act
            var actualOutput = builder.BuildDate(firstDate, secondDate);

            //Assert
            Assert.Equal(expedtedDateString, actualOutput);
        }
    }
}
