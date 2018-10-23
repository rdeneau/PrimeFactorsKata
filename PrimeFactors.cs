using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Of(int n)
        {
            for (var candidate = 2; candidate < n; candidate++)
            {
                while (n % candidate == 0)
                {
                    yield return candidate;
                    n /= candidate;
                }
            }

            if (n > 1)
            {
                yield return n;
            }
        }
    }
}
