
namespace DateHelperExample
{
    public static class DateHelper
    {
        public static bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static int GetDaysDifference(DateTime start, DateTime end)
        {
            return (end - start).Days;
        }
    }

}
