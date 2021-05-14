using System;

namespace CommandLineApp.Validators
{

    /// <summary>
    ///   Class containing date validation methods.
    /// </summary>
    public static class DateValidator
    {
        /// <summary>Determines whether the specified date is date.</summary>
        /// <param name="date">The date.</param>
        /// <returns>
        ///   <c>true</c> if the specified date is date; otherwise, <c>false</c>.</returns>
        public static bool IsDate(DateTime date)
        {
            return date.GetType() == typeof(DateTime);
        }

        /// <summary>Returns true if date is valid.</summary>
        /// <param name="dateToValid">The date to valid.</param>
        /// <param name="date">The date.</param>
        /// <returns>
        ///   <c>true</c> if the specified date to valid is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string dateToValid, out DateTime date)
        {
            return DateTime.TryParse(dateToValid, out date);
        }

        /// <summary>Checks that dates are the same.</summary>
        /// <param name="first">The first date</param>
        /// <param name="second">The second date</param>
        /// <returns>
        ///   <c>true</c> if the specified first date is same than second; otherwise, <c>false</c>.</returns>
        public static bool IsSame(DateTime first, DateTime second)
        {
            return first.Equals(second);
        }

        /// <summary>Determines whether the specified first is greater.</summary>
        /// <param name="first">The first date</param>
        /// <param name="second">The second date</param>
        /// <returns>
        ///   <c>true</c> if the specified first is greater; otherwise, <c>false</c>.</returns>
        public static bool IsGreater(DateTime first, DateTime second)
        {
            return DateTime.Compare(first, second) > 0;
        }
    }
}
