
using NorelyPoc.BlazorApp.Logic;
using NUnit.Framework;
using Xunit;

namespace NorelyPoc.Testsv4
{
    public class CounterLogicTests
    {
        [Fact]
        public void Counter_ShouldStartAtZero()
        {
            // Arrange
            var counter = new CounterLogic();

            // Act
            var initialValue = counter.CurrentCount;

            // Assert
            Assert.Equals(0, initialValue);
        }

        [Fact]
        public void Counter_ShouldIncrement_WhenIncrementCountCalled()
        {
            // Arrange
            var counter = new CounterLogic();

            // Act
            counter.IncrementCount();

            // Assert
            Assert.Equals(1, counter.CurrentCount);
        }
    }
}