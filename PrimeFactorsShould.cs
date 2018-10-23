using FluentAssertions;
using Xunit;

namespace PrimeFactorsKata
{
    public class PrimeFactorsShould
    {
        [Fact]
        public void Return_Empty_Given_1()
        {
            PrimeFactors.Of(1).Should().BeEmpty();
        }

        [Fact]
        public void Return_2_Given_2()
        {
            PrimeFactors.Of(2).Should().ContainInOrder(2);
        }
    }
}
