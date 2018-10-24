using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Of(int n)
        {
            for (var candidate = 2; n > 1; candidate = NextCandidate(candidate))
            {
                while (n % candidate == 0)
                {
                    yield return candidate;
                    n /= candidate;
                }
            }
        }

        private static int NextCandidate(int candidate) =>
            candidate == 2
                ? 3
                : candidate + 2;
    }
}
