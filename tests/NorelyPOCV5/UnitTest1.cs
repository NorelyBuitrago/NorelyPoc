
using NorelyPoc.BlazorApp.Logic;
using Assert = Xunit.Assert;

namespace NorelyPOCV5.Tests
{
    public class CounterLogicTests
    {
        [Fact]
        public void Counter_ShouldStartAtZero()
        {
            // Arrange
            var counter = new CounterLogicv2();

            // Act
            var initialValue = counter.CurrentCount;

            // Assert
            Assert.Equal(0, initialValue);
        }

        [Fact]
        public void Counter_ShouldIncrement_WhenIncrementCountCalled()
        {
            // Arrange
            var counter = new CounterLogicv2();

            // Act
            counter.IncrementCount();

            // Assert
            Assert.Equal(1, counter.CurrentCount);
        }
    }
}