using FluentAssertions;
using Xunit;

namespace PrimeFactorsKata
{
    public class PrimeFactorsShould
    {
        [Fact]
        public void Return_Empty_Given_One()
        {
            PrimeFactors.Of(1).Should().BeEmpty();
        }
    }
}
