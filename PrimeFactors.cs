using System.Collections.Generic;

namespace PrimeFactorsKata
{
    public static class PrimeFactors
    {
        public static IEnumerable<int> Of(int n)
        {
            while (n % 2 == 0)
            {
                yield return 2;
                n /= 2;
            }

            if (n > 1)
            {
                yield return n;
            }
        }
    }
}
