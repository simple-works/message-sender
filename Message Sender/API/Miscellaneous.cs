using System;

namespace MessageSender
{
    static class Miscellaneous
    {
        public static string GetRelativeTimeString(object dateTimeString)
        {
            return Convert.ToDateTime(dateTimeString).ToRelativeTimeString();
        }

        public static string GetRandomNumberString()
        {
            return new Random().Next(11111, 99999).ToString();
        }
    }
}
