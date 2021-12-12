using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace NuGet.Workflow
{
    /// <summary>
    ///     Represents the Fibonacci sequence.
    /// </summary>
    public class Fibonacci
    {
        public IEnumerable<BigInteger> Get()
        {
            (BigInteger first, BigInteger second) = (0, 1);

            while (true)
            {
                var result = first;

                yield return result;

                first = second;
                second = result + second;
            }
        }
    }
}
