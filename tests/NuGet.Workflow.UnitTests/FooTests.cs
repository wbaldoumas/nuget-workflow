using FluentAssertions;
using NUnit.Framework;

namespace NuGet.Workflow.UnitTests
{
    [TestFixture]
    public class FooTests
    {
        [Test]
        public void Foo_generates_expected_bar()
        {
            // arrange
            var foo = new Foo();

            // act
            var bar = foo.Bar();

            // assert
            bar.Should().Be("Bar");
        }
    }
}
