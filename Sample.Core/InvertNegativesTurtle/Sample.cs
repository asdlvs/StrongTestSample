using System;

namespace Sample.Core.InvertNegativesTurtle
{
    public class Sample
    {
        public int GetHardcodedNegative()
        {
            return -42;
        }

        public int GetNegativeParameter(int number)
        {
            return -number;
        }

        public int GetNegativeByCondition(bool value)
        {
            if (value)
            {
                return -2;
            }

            return -3;
        }

        public int GetRandomNegative()
        {
            var random = new Random();
            var value = random.Next(1, int.MaxValue);
            var negativeValue = value * (-1);

            return negativeValue;
        }
    }
}
