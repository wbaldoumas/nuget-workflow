using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace NuGet.Workflow.UnitTests
{
    /// <summary>
    ///     It is a good practice to have test coverage for your NuGet package. A widely used code library should generally
    ///     have very high test coverage, preferably 100% if you've added meaningful coverage exclusions properly.
    /// </summary>
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void Get_generates_expected_fibonacci_numbers()
        {
            // arrange
            const int takeCount = 10000;
            var fibonacci = new Fibonacci();

            // act
            var fibonacciNumbers = fibonacci.Take(takeCount).ToList();

            // assert
            fibonacciNumbers.Count.Should().Be(takeCount);
            fibonacciNumbers.Should().BeInAscendingOrder();

            fibonacciNumbers[0].Should().Be(0);
            fibonacciNumbers[1].Should().Be(1);

            for (var index = 2; index < fibonacciNumbers.Count; ++index)
            {
                fibonacciNumbers[index].Should().Be(fibonacciNumbers[index - 1] + fibonacciNumbers[index - 2]);
            }
        }
    }
}