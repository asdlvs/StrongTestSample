using System.Collections.Generic;
using System.Linq;

namespace Sample.Core.ReturnValueTurtle
{
    public class IntegerValueSample
    {
        private readonly List<int> _integers = new List<int>
        {
            1,2,3,5,8,13,21,34,55
        };

        public int ReturnIntBasedOnConditions(int p)
        {
            if (p < 0)
            {
                return p + 10;
            }
            if (p == 0)
            {
                return p;
            }
            if (p > 0)
            {
                return p + 30;
            }

            return 0;
        }

        public IEnumerable<int> GetOddWithMultiplication()
        {
           return _integers.Where(i => i % 2 != 0).Select(i => i - 1);
        }
    }
}

