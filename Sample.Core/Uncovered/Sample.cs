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
                return 1 + 1;
            }

            if (parameter == 2)
            {
                return 2 + 2;
            }

            if (parameter == 3)
            {
                return 3 + 3;
            }

            if (parameter == 4)
            {
                return 4 + 4;
            }

            return parameter + parameter;
        }
    }
}
