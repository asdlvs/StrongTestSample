namespace Sample.Core.ReturnValueTurtle
{
    public class FloatValueSample
    {
        public float ReturnFloatBasedOnConditions(float p)
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

            return p;
        }

        public float ReturnFloatAfterCalculation()
        {
            float x = 100;
            float value = x + 20;

            return value;
        }

        public float ReturnOne()
        {
            return 1;
        }
    }
}
