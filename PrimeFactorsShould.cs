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
        [InlineData(5)]
        public void Return_Given_Prime_Number(int n)
        {
            PrimeFactors.Of(n).Should().BeEquivalentTo(n);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void Decompose_Single_Multiple_Of_2(int n)
        {
            PrimeFactors.Of(2*n).Should().BeEquivalentTo(2, n);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void Decompose_Dual_Multiple_Of_2(int n)
        {
            PrimeFactors.Of(2*2*n).Should().BeEquivalentTo(2, 2, n);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void Decompose_Single_Multiple_Of_3(int n)
        {
            PrimeFactors.Of(3*n).Should().BeEquivalentTo(3, n);
        }

        [Fact]
        public void Decompose_Big_Number()
        {
            PrimeFactors.Of(1_010_021).Should().BeEquivalentTo(17, 19, 53, 59);
        }
    }
}
