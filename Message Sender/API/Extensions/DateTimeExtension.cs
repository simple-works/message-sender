using System;

namespace MessageSender
{
    static class DateTimeExtension
    {
        public static string ToRelativeTimeString(this DateTime datetime)
        {
            TimeSpan timeSpan = DateTime.Now.Subtract(datetime);
            int totalDays = (int)timeSpan.TotalDays;
            int totalSeconds = (int)timeSpan.TotalSeconds;
            if (totalDays < 0 || totalDays >= 31)
            {
                return null;
            }
            if (totalDays == 0)
            {
                if (totalSeconds < 60)
                {
                    return "just now";
                }

                if (totalSeconds < 120)
                {
                    return "1 minute ago";
                }

                if (totalSeconds < 3600)
                {
                    return string.Format("{0} minutes ago", Math.Floor((double)totalSeconds / 60));
                }

                if (totalSeconds < 7200)
                {
                    return "1 hour ago";
                }

                if (totalSeconds < 86400)
                {
                    return string.Format("{0} hours ago", Math.Floor((double)totalSeconds / 3600));
                }
            }

            if (totalDays == 1)
            {
                return "yesterday";
            }

            if (totalDays < 7)
            {
                return string.Format("{0} days ago", totalDays);
            }

            if (totalDays < 31)
            {
                return string.Format("{0} weeks ago", Math.Ceiling((double)totalDays / 7));
            }

            return null;
        }
    }
}
