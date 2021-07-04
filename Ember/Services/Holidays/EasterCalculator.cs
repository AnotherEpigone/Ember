using System;

namespace Ember.Services.Holidays
{
    public class EasterCalculator
    {
        public DateTime Get(int year)
        {
            // Based on the "New Scientist" algorithm published 1961.
            // Golden number = lunar cycle year.
            var goldenNumber = year % 19;
            var century = year / 100;
            var shortYear = year % 100;

            // not sure why, this is which 400 year period we're in.
            var d = century / 4;

            // leftover centuries within the 4 century period.
            var e = century % 4;

            // ?????
            var g = ((8 * century) + 13) / 25;
            var h = ((19 * goldenNumber) + century - d - g + 15) % 30;
            var i = shortYear / 4;
            var k = shortYear % 4;
            var l = (32 + (2 * e) + (2 * i) - h - k) % 7;
            var m = (goldenNumber + (11 * h) + (19 * l)) / 433;

            // now we get the month and day based on the insane magic numbers above!
            var month = (h + l - (7 * m) + 90) / 25;
            var day = (h + l - (7 * m) + (33 * month) + 19) % 32;

            return new DateTime(year, month, day);
        }
    }
}
