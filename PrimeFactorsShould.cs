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

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void Return_Given_Prime_Number(int n)
        {
            PrimeFactors.Of(n).Should().BeEquivalentTo(n);
        }

        [Fact]
        public void Return_2_and_2_Given_4()
        {
            PrimeFactors.Of(4).Should().BeEquivalentTo(2, 2);
        }
    }
}
