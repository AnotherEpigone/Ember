using Ember.Services.Holidays;
using System;
using Xunit;

namespace EmberTests
{
    public class EasterCalculatorTests
    {
        [Theory]
        [InlineData(1900, 4, 15)]
        [InlineData(1961, 4, 2)]
        [InlineData(2020, 4, 12)]
        [InlineData(2021, 4, 4)]
        [InlineData(2022, 4, 17)]
        public void Get(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var computus = new EasterCalculator();
            var date = computus.Get(year);
            Assert.Equal(expected, date);
        }
    }
}
