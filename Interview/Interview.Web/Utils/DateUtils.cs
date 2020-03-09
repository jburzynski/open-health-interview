using System;

namespace Interview.Web.Utils
{
    public static class DateUtils
    {
        public static DateTime FromUnixSeconds(long seconds)
        {
            return new DateTime(1970, 1, 1)
                .AddSeconds(seconds);
        }
    }
}