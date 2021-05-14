using System;

namespace CommandLineApp.Interfaces
{
    public interface IDateBuilder
    {
        string BuildDate(DateTime first, DateTime second);
    }
}
