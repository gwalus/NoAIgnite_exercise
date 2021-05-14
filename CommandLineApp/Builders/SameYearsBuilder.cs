using CommandLineApp.Interfaces;
using System;

namespace CommandLineApp.Builders
{
    public class SameYearsBuilder : IDateBuilder
    {
        public string BuildDate(DateTime first, DateTime second)
        {
            return $"{first:dd.MM} - {second:dd.MM.yyyy}";
        }
    }
}
