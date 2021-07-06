using Ember.Services.Holidays;
using System;
using Xunit;

namespace EmberTests
{
    public class EmberDayCalculatorTests
    {
        [Fact]
        public void GetAdventEmbertideStart()
        {
            var calculator = new EmberDayCalculator();
            var date = calculator.GetAdventEmbertideStart(2021);

            Assert.Equal(new DateTime(2021, 12, 15), date);
        }

        [Fact]
        public void GetLentenEmbertideStart()
        {
            var calculator = new EmberDayCalculator();
            var date = calculator.GetLentenEmbertideStart(2021);

            Assert.Equal(new DateTime(2021, 2, 24), date);
        }

        [Fact]
        public void GetWhitEmbertideStart()
        {
            var calculator = new EmberDayCalculator();
            var date = calculator.GetWhitEmbertideStart(2021);

            Assert.Equal(new DateTime(2021, 5, 26), date);
        }

        [Fact]
        public void GetMichaelmasEmbertideStart()
        {
            var calculator = new EmberDayCalculator();
            var date = calculator.GetMichaelmasEmbertideStart(2021);

            Assert.Equal(new DateTime(2021, 9, 15), date);
        }
    }
}
