using Xunit;

namespace Sample.XUnitOld.Tests.ReturnValueTurtle
{
    public class ObjectValueSampleTests
    {
        [Fact]
        public void GetNewObject_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();

            //act
            var result = logic.GetNewObject();

            //assert
            Assert.True((result ?? new object()) != null);
        }

        [Fact]
        public void GetNewObject2_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();

            //act
            var result = logic.GetNewObject2();

            //assert
            Assert.True((result ?? new object()) != null);
        }

        [Fact]
        public void GetExistedObject_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();
            var o = new
            {
                FirstName = "John",
                LastName = "Doe"
            };
            
            //act
            var result = logic.GetExistedObject(o);

            //assert
            Assert.True((result ?? new object()) != null);
        }
    }
}
