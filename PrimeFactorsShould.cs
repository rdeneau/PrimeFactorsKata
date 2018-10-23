using FluentAssertions;
using Xunit;

namespace PrimeFactorsKata
{
    public class PrimeFactorsShould
    {
        [Fact]
        public void SmokeTest()
        {
            true.Should().Be(false);
        }
    }
}
