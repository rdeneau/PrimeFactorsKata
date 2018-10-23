using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Of(int n)
        {
            if (n <= 1)
                yield break;

            yield return n;
        }
    }
}
