using Ember.Services.Holidays;
using System;
using Xunit;

namespace EmberTests
{
    public class EasterCalculatorTests
    {
        [Theory]
        [InlineData(1961, 4, 2)]
        [InlineData(2021, 4, 4)]
        public void Get(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var computus = new EasterCalculator();
            var date = computus.Get(year);
            Assert.Equal(expected, date);
        }
    }
}
