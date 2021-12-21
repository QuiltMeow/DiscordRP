using System;

namespace DiscordRP
{
    public class DateHelper
    {
        public static DateTime getDateTimeFromMilliSecond(long milliSecond)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(milliSecond);
            return new DateTime(1970, 1, 1) + time;
        }

        public static long getMilliSecondFromDateTime(DateTime date)
        {
            return (long)(date - new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
    }
}