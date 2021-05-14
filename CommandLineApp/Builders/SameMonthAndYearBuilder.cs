using CommandLineApp.Interfaces;
using System;

namespace CommandLineApp.Builders
{
    public class SameMonthAndYearBuilder : IDateBuilder
    {
        public string BuildDate(DateTime first, DateTime second)
        {
            return string.Format($"{first:dd} - {second:dd.MM.yyyy}");
        }
    }
}
