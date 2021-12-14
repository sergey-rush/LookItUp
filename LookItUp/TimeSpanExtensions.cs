using System;
using System.Collections.Generic;
using System.Linq;

namespace LookItUp
{
    public static class TimeSpanExtensions
    {
        static readonly string[] days = { "день", "дня", "дней" };
        static readonly string[] hours = { "час", "часа", "часов" };
        static readonly string[] minutes = { "минута", "минуты", "минут" };
        static readonly string[] seconds = { "секунда", "секунды", "секунд" };

        public static string FormatTimeSpan(this TimeSpan timeSpan)
        {
            string output = String.Empty;
            int totalHours = (timeSpan.Days * 24) + timeSpan.Hours;

            if (totalHours == 0 && timeSpan.Minutes == 0)
            {
                output = $"{totalHours}:{timeSpan:mm\\:ss}";
            }
            else
            {
                output = $"{totalHours}:{timeSpan:mm}";
            }
            return output;
        }

        public static string ToLongReadable(this TimeSpan span)
        {
            string output = string.Join(" ", span.GetLongStringElements()
                .Where(str => !string.IsNullOrWhiteSpace(str)));

            //Debug.WriteLine($"{span} {output}");
            return output;
        }

        private static IEnumerable<string> GetLongStringElements(this TimeSpan span)
        {
            int numHours = (int)Math.Floor(span.TotalDays) * 24 + span.Hours;
            yield return FormatDatePart(numHours, hours);
            yield return FormatDatePart(span.Minutes, minutes);
            yield return FormatDatePart(span.Seconds, seconds);
        }

        public static string ToShortReadable(this TimeSpan span)
        {
            string output = string.Join(" ", span.GetShortStringElements()
                .Where(str => !string.IsNullOrWhiteSpace(str)));

            //Debug.WriteLine($"{span} {output}");
            return output;
        }

        private static IEnumerable<string> GetShortStringElements(this TimeSpan span)
        {
            int numHours = (int)Math.Floor(span.TotalDays) * 24 + span.Hours;
            yield return FormatDatePart(numHours, hours);
            yield return FormatDatePart(span.Minutes, minutes);
            //yield return GetSecondsString(span.Seconds);
        }

        public static string ToFullReadable(this TimeSpan span)
        {
            return string.Join(" ", span.GetFullStringElements()
                .Where(str => !string.IsNullOrWhiteSpace(str)));
        }

        private static IEnumerable<string> GetFullStringElements(this TimeSpan span)
        {
            yield return FormatDatePart((int)Math.Floor(span.TotalDays), days);
            yield return FormatDatePart(span.Hours, hours);
            yield return FormatDatePart(span.Minutes, minutes);
            yield return FormatDatePart(span.Seconds, seconds);
        }

        static string FormatDatePart(int value, string[] options)
        {
            if (value == 0)
            {
                return string.Empty;
            }

            int input = value;
            string option = options[2];

            value = Math.Abs(value) % 100;

            if (value > 10 && value < 15)
                option = options[2];

            value %= 10;
            if (value == 1)
            {
                option = options[0];
            }

            if (value > 1 && value < 5)
            {
                option = options[1];
            }

            return $"{input} {option}";
        }

        //private static string GetDaysString(int days)
        //{
        //    if (days == 0)
        //        return string.Empty;

        //    if (days == 1)
        //        return "1 день";

        //    return string.Format("{0:0} дней", days);
        //}

        //private static string GetShortHoursString(int hours, int days)
        //{
        //    if (hours == 0 && days == 0)
        //        return string.Empty;

        //    int totalHours = (days * 24) + hours;

        //    if (totalHours == 1)
        //        return "1 час";

        //    return string.Format("{0:0} часов", totalHours);
        //}

        //private static string GetHoursString(int hours)
        //{
        //    if (hours == 0)
        //        return string.Empty;

        //    if (hours == 1)
        //        return "1 час";

        //    return string.Format("{0:0} часов", hours);
        //}

        //private static string GetMinutesString(int minutes)
        //{
        //    if (minutes == 0)
        //        return string.Empty;

        //    if (minutes == 1)
        //        return "1 минута";

        //    return string.Format("{0:0} минут", minutes);
        //}

        //private static string GetSecondsString(int seconds)
        //{
        //    if (seconds == 0)
        //        return string.Empty;

        //    if (seconds == 1)
        //        return "1 секунда";

        //    return string.Format("{0:0} секунд", seconds);
        //}
    }
}