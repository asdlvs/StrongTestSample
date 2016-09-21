using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Complex
{
    public class ComplexSample
    {
        public List<int> GetChars(string test)
        {
            List<int> result = new List<int>();
            foreach (var ch in test)
            {
                result.Add(ch.GetHashCode());
            }
            return result;
        }
    }
}

