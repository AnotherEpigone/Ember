using System;

namespace Ember.Services.Holidays
{
    public class EmberDayCalculator
    {
        public DateTime GetAdventEmbertideStart(int year)
        {
            // Wednesday after Gaudete Sunday.
            // Gaudete Sunday = 3rd Sunday of Advent
            // Advent begins on the closest Sunday to St. Andrew’s Day(November 30).
            var stAndrewsDay = new DateTime(year, 11, 30);
            var firstSundayOfAdvent = GetClosestSunday(stAndrewsDay);
            var thirdSundayOfAdvent = firstSundayOfAdvent.AddDays(14);
            return thirdSundayOfAdvent.AddDays(3);
        }

        public DateTime GetLentenEmbertideStart(int year)
        {
            // Wednesday after Quadragesima Sunday
            // Quadragesima = 1st Sunday of Lent
            // Lent = 6 Sundays before Easter
            // Easter = Sunday after the first full moon after March 21
            var easterSunday = new EasterCalculator().Get(year);
            var quadragesima = easterSunday.AddDays(-42);
            return quadragesima.AddDays(3);
        }

        public DateTime GetWhitEmbertideStart(int year)
        {
            // Wednesday after Pentecost Sunday
            // Pentecost = 50th day(inclusive) from Easter
            // Easter = Sunday after the first full moon after March 21
            var easterSunday = new EasterCalculator().Get(year);
            var whitSunday = easterSunday.AddDays(49);
            return whitSunday.AddDays(3);
        }

        public DateTime GetMichaelmasEmbertideStart(int year)
        {
            // Wednesday after the Exaltation of the Holy Cross (Sept 14)
            var holyCross = new DateTime(year, 9, 14);
            return GetNextWednesday(holyCross);
        }

        private DateTime GetClosestSunday(DateTime date)
        {
            return date.DayOfWeek switch
            {
                DayOfWeek.Sunday => date,
                DayOfWeek.Monday => date.AddDays(-1),
                DayOfWeek.Tuesday => date.AddDays(-2),
                DayOfWeek.Wednesday => date.AddDays(-3),
                DayOfWeek.Thursday => date.AddDays(3),
                DayOfWeek.Friday => date.AddDays(2),
                DayOfWeek.Saturday => date.AddDays(1),
                _ => throw new NotImplementedException(),
            };
        }

        private DateTime GetNextWednesday(DateTime date)
        {
            return date.DayOfWeek switch
            {
                DayOfWeek.Sunday => date.AddDays(3),
                DayOfWeek.Monday => date.AddDays(2),
                DayOfWeek.Tuesday => date.AddDays(1),
                DayOfWeek.Wednesday => date.AddDays(7),
                DayOfWeek.Thursday => date.AddDays(6),
                DayOfWeek.Friday => date.AddDays(5),
                DayOfWeek.Saturday => date.AddDays(4),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
