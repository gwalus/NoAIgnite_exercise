using CommandLineApp.Interfaces;
using System;

namespace CommandLineApp.Builders
{
    public class DefaultBuilder : IDateBuilder
    {
        public string BuildDate(DateTime first, DateTime second)
        {
            return string.Format($"{first:dd.MM.yyyy} - {second:dd.MM.yyyy}");
        }
    }
}
