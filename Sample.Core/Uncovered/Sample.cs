using System.Collections.Generic;
using System.Linq;

namespace Sample.Core.Uncovered
{
    public class Sample
    {
        public int BranchesLogic(int parameter)
        {
            if (parameter == 1)
            {
                return parameter + 1;
            }

            if (parameter == 2)
            {
                return parameter + 2;
            }

            if (parameter == 3)
            {
                return parameter + 3;
            }

            if (parameter == 4)
            {
                return parameter + 4;
            }

            return parameter + parameter;
        }

        public int AnotherBranchesLogic(int parameter)
        {
            if (parameter%2 == 0) { return 0; }

            if (parameter == 1)
            {
                return parameter + 1;
            }

            if (parameter == 3)
            {
                return parameter + 3;
            }

            if (parameter == 5)
            {
                return parameter + 5;
            }

            if (parameter == 7)
            {
                return parameter + 7;
            }

            return parameter + parameter;
        }
    }
}
