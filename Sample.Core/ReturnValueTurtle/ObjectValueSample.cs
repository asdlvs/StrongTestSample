namespace Sample.Core.ReturnValueTurtle
{
    public class ObjectValueSample
    {
        public object GetNewObject()
        {
            var o = new object();
            return o;
        }

        public object GetNewObject2()
        {
             return new object();
        }

        public object GetExistedObject(object o)
        {
            return o;
        }
    }
}

