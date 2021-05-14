using System;

namespace CommandLineApp.Builders
{
    public class DateBuilder
    {
        private readonly DateTime _first;
        private readonly DateTime _second;

        public DateBuilder(DateTime first, DateTime second)
        {
            _first = first;
            _second = second;
        }

        public string CalculateDates()
        {
            if (_first.Month.Equals(_second.Month) && _first.Year.Equals(_second.Year))
            {
                return new SameMonthAndYearBuilder().BuildDate(_first, _second);
            }

            if (_first.Year.Equals(_second.Year))
            {
                return new SameYearsBuilder().BuildDate(_first, _second);
            }

            return new DefaultBuilder().BuildDate(_first, _second);
        }
    }
}
