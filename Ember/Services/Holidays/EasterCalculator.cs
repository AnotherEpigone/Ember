using System;

namespace Ember.Services.Holidays
{
    public class EasterCalculator
    {
        public DateTime Get(int year)
        {
            // Based on the "New Scientist" algorithm published 1961.
            // note that the single-letter variable names are as-written in
            // the published algorithm.
            var goldenNumber = year % 19; // position in 19 year lunar cycle.
            var century = year / 100;
            var shortYear = year % 100;

            // not sure why, this is which 400 year period we're in.
            var d = century / 4;

            // leftover centuries within the 4 century period.
            var e = century % 4;

            // not sure
            var g = ((8 * century) + 13) / 25;

            // h = days between the spring equinox and the following full moon.
            var h = ((19 * goldenNumber) + century - d - g + 15) % 30;

            // not sure
            var i = shortYear / 4;
            var k = shortYear % 4;
            var l = (32 + (2 * e) + (2 * i) - h - k) % 7;
            var m = (goldenNumber + (11 * h) + (19 * l)) / 433;

            // now we get the month and day based on the magic numbers above
            var month = (h + l - (7 * m) + 90) / 25;
            var day = (h + l - (7 * m) + (33 * month) + 19) % 32;

            return new DateTime(year, month, day);
        }
    }
}
