namespace Sample.Core.ReturnValueTurtle
{
    public class BooleanValueSample
    {
        public bool ReturnTrue()
        {
            return true;
        }

        public bool ReturnFalse()
        {
            return false;
        }

        public bool ReturnIfEven(int number)
        {
            return number % 2 == 0;
        }

        public bool Streight(bool value)
        {
            return value;
        }

        public bool Invert(bool value)
        {
            var result = value;
             return !result;
        }
    }
}

