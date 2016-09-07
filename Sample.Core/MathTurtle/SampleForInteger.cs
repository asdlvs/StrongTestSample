namespace Sample.Core.MathTurtle
{
    public class SampleForInteger
    {
        public int Summ(int a, int b)
        {
            var result = a + b;
            return result;
        }

        public int Sub(int a, int b)
        {
            var result = a - b;
            return result;
        }

        public int Mul(int a, int b)
        {
            var result = a * b;
            return result;
        }

        public int Div(int a, int b)
        {
            var result = a / b;
            return result;
        }

        public int Rem(int a, int b)
        {
            var result = a % b;
            return result;
        }

        public int Complex(int a, int b, int c, int d)
        {
            var result = a & b | c ^ d;
            return ++result;
        }
    }
}
